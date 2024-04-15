using System;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class StructureType(FullName fullName) : BuilderType(fullName)
    {
        public override void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(typeDef);
            base.ResolveType(context, typeDef);

            foreach (var handle in typeDef.GetFields())
            {
                var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                field.Attributes = fieldDef.Attributes;
                Fields.Add(field);
                context.AddDependencies(field.Type);
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

            context.Writer.WriteLine("[StructLayout(LayoutKind.Sequential)]");
            context.Writer.Write($"public partial struct {FullName.Name}");
            //if (BaseType != null)
            //    throw new NotSupportedException();

            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                for (var i = 0; i < Fields.Count; i++)
                {
                    var field = Fields[i];
                    var mapped = context.MapType(field.Type);
                    if (mapped.UnmanagedType.HasValue)
                    {
                        context.Writer.WriteLine($"[MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                    }

                    context.Writer.Write("public ");
                    context.Writer.Write(mapped.GetGeneratedName(context));
                    context.Writer.Write(' ');
                    context.Writer.Write(field);
                    context.Writer.WriteLine(';');
                }
            });
        }
    }
}
