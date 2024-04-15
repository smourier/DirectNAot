using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class EnumType(FullName fullName) : BuilderType(fullName)
    {
        public virtual bool IsFlags { get; set; }
        public virtual BuilderType? UnderlyingType { get; set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is EnumType typed)
            {
                typed.IsFlags = IsFlags;
                typed.UnderlyingType = UnderlyingType;
            }
        }

        public override bool IsConstableType() => true;

        public override void ResolveFields(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            foreach (var handle in typeDef.GetFields())
            {
                var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                if (fieldDef.Attributes.HasFlag(FieldAttributes.RTSpecialName))
                {
                    UnderlyingType = field.Type;
                    continue;
                }

                Fields.Add(field);
                field.DefaultValueAsBytes = context.MetadataReader.GetConstantBytes(fieldDef.GetDefaultValue());
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

            if (IsFlags)
            {
                context.Writer.WriteLine("[Flags]");
            }

            context.Writer.Write($"public enum {FullName.Name}");
            if (UnderlyingType != null)
            {
                var typeName = UnderlyingType.GetGeneratedName(context);
                if (typeName != "int")
                {
                    context.Writer.Write($" : {typeName}");
                }
            }

            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                for (var i = 0; i < Fields.Count; i++)
                {
                    var field = Fields[i];
                    context.Writer.Write(field);

                    if (field.DefaultValueAsBytes != null)
                    {
                        context.Writer.Write(" = ");
                        context.Writer.Write(field.Type.GetValueAsString(context, field.DefaultValue));
                    }
                    context.Writer.WriteLine(',');
                }
            });
        }
    }
}
