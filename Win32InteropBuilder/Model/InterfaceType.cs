using System;
using System.Linq;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class InterfaceType(FullName fullName) : BuilderType(fullName)
    {
        public virtual bool IsIUnknownDerived { get; protected set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is InterfaceType typed)
            {
                typed.IsIUnknownDerived = IsIUnknownDerived;
            }
        }

        public override void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(typeDef);
            base.ResolveType(context, typeDef);

            foreach (var handle in typeDef.GetMethods())
            {
                var methodDef = context.MetadataReader.GetMethodDefinition(handle);
                var method = context.CreateBuilderMethod(context.MetadataReader.GetString(methodDef.Name));
                Methods.Add(method);
                foreach (var phandle in methodDef.GetParameters())
                {
                    var parameterDef = context.MetadataReader.GetParameter(phandle);
                    var parameter = context.CreateBuilderParameter(context.MetadataReader.GetString(parameterDef.Name), parameterDef.SequenceNumber);
                    // remove 'this'
                    if (string.IsNullOrEmpty(parameter.Name) && parameter.SequenceNumber == 0)
                        continue;

                    if (parameter.Name == "ppAdapter")
                    {
                    }

                    parameter.Attributes = parameterDef.Attributes;
                    parameter.IsComOutPtr = context.MetadataReader.IsComOutPtr(parameterDef.GetCustomAttributes());
                    method.Parameters.Add(parameter);
                }
                method.SortParameters();

                var dec = methodDef.DecodeSignature(context.SignatureTypeProvider, null);
                method.ReturnType = dec.ReturnType;
                if (method.ReturnType != null)
                {
                    context.AddDependencies(method.ReturnType);
                }

                if (method.Parameters.Count != dec.ParameterTypes.Length)
                    throw new InvalidOperationException();

                for (var i = 0; i < method.Parameters.Count; i++)
                {
                    method.Parameters[i].Type = dec.ParameterTypes[i];
                    if (method.Parameters[i].Type == null)
                        throw new InvalidOperationException();

                    context.AddDependencies(method.Parameters[i].Type!);
                }
            }

            var interfaces = typeDef.GetInterfaceImplementations();
            foreach (var iface in interfaces)
            {
                var fn = context.MetadataReader.GetFullName(iface);
                if (fn == FullName.IUnknown)
                {
                    IsIUnknownDerived = true;
                    continue;
                }

                var typeRefType = context.AllTypes[fn];
                context.AddDependencies(typeRefType);
                Interfaces.Add(typeRefType);
            }
        }

        protected override void GenerateTypeCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            if (SupportedOSPlatform != null)
            {
                context.Writer.WriteLine($"[SupportedOSPlatform(\"{SupportedOSPlatform}\")]");
            }

            context.Writer.WriteLine($"[GeneratedComInterface, Guid(\"{Guid.GetValueOrDefault()}\")]");
            context.Writer.Write($"public partial interface {FullName.Name}");

            if (Interfaces.Count > 0)
            {
                context.Writer.Write($" : {string.Join(", ", Interfaces.Select(i => i.FullName.GetRelativeTo(FullName)))}");
            }

            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                for (var i = 0; i < Methods.Count; i++)
                {
                    var method = Methods[i];
                    context.Writer.WriteLine("[PreserveSig]");
                    if (method.ReturnType != null)
                    {
                        var mapped = context.MapType(method.ReturnType);
                        if (mapped.UnmanagedType.HasValue)
                        {
                            context.Writer.WriteLine($"[return: MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                        }
                        context.Writer.Write(mapped.GetGeneratedName(context));
                    }
                    else
                    {
                        context.Writer.Write("void");
                    }
                    context.Writer.Write(' ');
                    context.Writer.Write(method);

                    context.Writer.Write('(');
                    for (var j = 0; j < method.Parameters.Count; j++)
                    {
                        var parameter = method.Parameters[j];
                        parameter.GeneratedCode(context);
                        if (j != method.Parameters.Count - 1)
                        {
                            context.Writer.Write(", ");
                        }
                    }
                    context.Writer.WriteLine(");");

                    if (i != Methods.Count - 1)
                    {
                        context.Writer.WriteLine();
                    }
                }
            });
        }
    }
}
