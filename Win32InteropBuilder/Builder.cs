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

        protected virtual BuilderType CreateBuilderType(BuilderContext context, FullName fullName) => new(fullName);
        protected virtual InterfaceType CreateInterfaceType(BuilderContext context, FullName fullName) => new(fullName);
        protected virtual StructureType CreateStructureType(BuilderContext context, FullName fullName) => new(fullName);
        protected virtual BuilderMethod CreateBuilderMethod(BuilderContext context, string name) => new(name);
        protected virtual BuilderParameter CreateBuilderParameter(BuilderContext context, string name, int sequenceNumber) => new(name, sequenceNumber);
        protected virtual BuilderField CreateBuilderField(BuilderContext context, string name, BuilderType type) => new(name, type);

        protected virtual void GatherTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            AddWellKnownTypes(context);
            var matches = new HashSet<BuilderType>();
            var reverses = new HashSet<BuilderType>();

            foreach (var typeDef in context.MetadataReader.TypeDefinitions.Select(context.MetadataReader.GetTypeDefinition))
            {
                BuilderType type;
                if (typeDef.Attributes.HasFlag(TypeAttributes.Interface))
                {
                    type = CreateInterfaceType(context, context.MetadataReader.GetFullName(typeDef));
                }
                else
                {
                    var isStructure = context.MetadataReader.IsStructure(typeDef);
                    if (isStructure)
                    {
                        type = CreateStructureType(context, context.MetadataReader.GetFullName(typeDef));
                    }
                    else
                    {
                        type = CreateBuilderType(context, context.MetadataReader.GetFullName(typeDef));
                    }
                }
                if (type.FullName.Namespace.Length == 0)
                    continue;

                context.AllTypes[type.FullName] = type;
                context.TypeDefinitions[type.FullName] = typeDef;

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

            // remove excluded matches
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

            _ = context.AllTypes[type.FullName];
            if (!context.TypeDefinitions.TryGetValue(type.FullName, out var typeDef))
            {
                //Console.WriteLine(type.FullName);
                return;
            }

            if (context.TypesToBuild.Contains(type))
                return;

            if (type is InterfaceType ifaceType)
            {
                foreach (var handle in typeDef.GetMethods())
                {
                    var methodDef = context.MetadataReader.GetMethodDefinition(handle);
                    var method = CreateBuilderMethod(context, context.MetadataReader.GetString(methodDef.Name));
                    type.Methods.Add(method);
                    foreach (var phandle in methodDef.GetParameters())
                    {
                        var parameterDef = context.MetadataReader.GetParameter(phandle);
                        var parameter = CreateBuilderParameter(context, context.MetadataReader.GetString(parameterDef.Name), parameterDef.SequenceNumber);
                        // remove 'this'
                        if (string.IsNullOrEmpty(parameter.Name) && parameter.SequenceNumber == 0)
                            continue;

                        method.Parameters.Add(parameter);
                    }
                    method.SortParameters();

                    var dec = methodDef.DecodeSignature(SignatureTypeProvider.Instance, null);
                    method.ReturnType = dec.ReturnType;
                    if (method.ReturnType != null)
                    {
                        AddDependencies(context, method.ReturnType);
                    }

                    for (var i = 0; i < dec.ParameterTypes.Length; i++)
                    {
                        method.Parameters[i].Type = dec.ParameterTypes[i];
                        if (method.Parameters[i].Type != null)
                        {
                            AddDependencies(context, method.Parameters[i].Type!);
                        }
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
                    var field = CreateBuilderField(context, context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(SignatureTypeProvider.Instance, null));
                    type.Fields.Add(field);
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
                var def = context.TypeDefinitions[type.FullName];
                if (context.MetadataReader.IsHandle(def))
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
                var typeDef = context.TypeDefinitions[type.FullName];
                context.MetadataReader.SetDocumentation(typeDef.GetCustomAttributes(), type);
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
                using var iw = new IndentedTextWriter(file);
                type.GenerateCode(iw);
            }
        }
    }
}
