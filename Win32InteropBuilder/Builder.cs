using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    public class Builder
    {
        public static JsonSerializerOptions JsonSerializerOptions { get; } = new()
        {
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        };

        public virtual BuilderContext CreateBuilderContext(BuilderConfiguration configuration) => new(configuration);

        public virtual void Build(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.Configuration.WinMdPath == null)
                throw new ArgumentException(null, nameof(context));

            using var stream = File.OpenRead(context.Configuration.WinMdPath);
            using var pe = new PEReader(stream);
            context.MetadataReader = pe.GetMetadataReader();
            GatherTypes(context);
            GenerateTypes(context);
        }

        protected virtual void GatherTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            AddWellKnownTypes(context);
            var matches = new HashSet<BuilderType>();
            var reverses = new HashSet<BuilderType>();

            foreach (var typeDef in context.MetadataReader.TypeDefinitions.Select(context.MetadataReader.GetTypeDefinition))
            {
                var type = context.CreateBuilderType(typeDef);
                if (type.FullName.Namespace.Length == 0)
                    continue;

                context.AllTypes[type.FullName] = type;
                context.TypeDefinitions[type.FullName] = typeDef;
                type.Guid = context.MetadataReader.GetInteropGuid(typeDef);

                foreach (var match in context.Configuration.Inputs.Where(x => x.Matches(type)))
                {
                    if (match.IsReverse)
                    {
                        reverses.Add(type);
                    }
                    else
                    {
                        matches.Add(type);
                    }
                }
            }

            foreach (var match in reverses.ToArray())
            {
                matches.Remove(match);
            }

            foreach (var match in matches)
            {
                AddDependencies(context, match);
            }

            RemoveNonGeneratedTypes(context);
        }

        protected virtual void AddDependencies(BuilderContext context, BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(type);
            if (!context.TypeDefinitions.TryGetValue(type.FullName, out var typeDef))
                return;

            if (context.TypesToBuild.Contains(type))
                return;

            if (type is InterfaceType ifaceType)
            {
                foreach (var handle in typeDef.GetMethods())
                {
                    var methodDef = context.MetadataReader.GetMethodDefinition(handle);
                    var method = context.CreateBuilderMethod(context.MetadataReader.GetString(methodDef.Name));
                    type.Methods.Add(method);
                    foreach (var phandle in methodDef.GetParameters())
                    {
                        var parameterDef = context.MetadataReader.GetParameter(phandle);
                        var parameter = context.CreateBuilderParameter(context.MetadataReader.GetString(parameterDef.Name), parameterDef.SequenceNumber);
                        // remove 'this'
                        if (string.IsNullOrEmpty(parameter.Name) && parameter.SequenceNumber == 0)
                            continue;

                        method.Parameters.Add(parameter);
                    }
                    method.SortParameters();

                    var dec = methodDef.DecodeSignature(context.SignatureTypeProvider, null);
                    method.ReturnType = dec.ReturnType;
                    if (method.ReturnType != null)
                    {
                        AddDependencies(context, method.ReturnType);
                    }

                    if (method.Parameters.Count != dec.ParameterTypes.Length)
                        throw new InvalidOperationException();

                    for (var i = 0; i < method.Parameters.Count; i++)
                    {
                        method.Parameters[i].Type = dec.ParameterTypes[i];
                        if (method.Parameters[i].Type == null)
                            throw new InvalidOperationException();

                        AddDependencies(context, method.Parameters[i].Type!);
                    }
                }

                var interfaces = typeDef.GetInterfaceImplementations();
                foreach (var iface in interfaces)
                {
                    var fn = context.MetadataReader.GetFullName(iface);
                    if (fn == FullName.IUnknown)
                    {
                        ifaceType.IsIUnknownDerived = true;
                        continue;
                    }

                    var typeRefType = context.AllTypes[fn];
                    AddDependencies(context, typeRefType);
                    type.Interfaces.Add(typeRefType);
                }
            }
            else if (type is StructureType)
            {
                foreach (var handle in typeDef.GetFields())
                {
                    var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                    var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                    type.Fields.Add(field);
                    AddDependencies(context, field.Type);
                }
            }
            else if (type is EnumType)
            {
                foreach (var handle in typeDef.GetFields())
                {
                    var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                    if (fieldDef.Attributes.HasFlag(FieldAttributes.RTSpecialName))
                        continue;

                    var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                    type.Fields.Add(field);
                    field.DefaultValue = context.MetadataReader.GetConstantBytes(fieldDef.GetDefaultValue());
                }
            }

            context.TypesToBuild.Add(type);
        }

        protected virtual void RemoveNonGeneratedTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            context.TypesToBuild.Remove(new BuilderType(FullName.IUnknown));
            context.TypesToBuild.Remove(new BuilderType(FullName.HRESULT));
            RemoveHandleTypes(context);
        }

        protected virtual void RemoveHandleTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            foreach (var type in context.TypesToBuild.ToArray())
            {
                if (context.TypeDefinitions.TryGetValue(type.FullName, out var typeDef) &&
                    context.MetadataReader.IsHandle(typeDef, context.SignatureTypeProvider))
                {
                    context.TypesToBuild.Remove(type);
                }
            }
        }

        protected virtual void AddWellKnownTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            foreach (var kv in BuilderType.WellKnownTypes)
            {
                context.AllTypes[kv.Key] = kv.Value;
            }
        }

        protected virtual void GenerateTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.OutputDirectoryPath);

            IOUtilities.DirectoryDelete(context.Configuration.OutputDirectoryPath, true);
            foreach (var type in context.TypesToBuild.OrderBy(t => t.FullName))
            {
                if (context.TypeDefinitions.TryGetValue(type.FullName, out var typeDef))
                {
                    var atts = typeDef.GetCustomAttributes();
                    context.MetadataReader.SetDocumentation(atts, type);
                    context.MetadataReader.SetSupportedOSPlatform(atts, type);
                }

                Console.WriteLine(type);

                var ns = string.Empty;
                var unified = context.Configuration.UnifyNamespaces.Nullify();
                if (unified == null)
                {
                    ns = type.FullName.Namespace.Replace('.', Path.DirectorySeparatorChar);
                }

                var fileName = type.FileName + ".cs";
                var typePath = Path.Combine(context.Configuration.OutputDirectoryPath, ns, fileName);
                IOUtilities.FileEnsureDirectory(typePath);
                using var file = new StreamWriter(typePath, false);
                context.Writer = new IndentedTextWriter(file);
                try
                {
                    type.GenerateCode(context);
                }
                finally
                {
                    context.Writer.Dispose();
                    context.Writer = null;
                }
            }
        }
    }
}
