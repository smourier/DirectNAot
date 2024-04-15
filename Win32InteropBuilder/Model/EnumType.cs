using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class EnumType(FullName fullName) : BuilderType(fullName)
    {
        public virtual bool IsFlags { get; protected set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is EnumType typed)
            {
                typed.IsFlags = IsFlags;
            }
        }

        public override void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(typeDef);
            base.ResolveType(context, typeDef);

            foreach (var handle in typeDef.GetFields())
            {
                var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                if (fieldDef.Attributes.HasFlag(FieldAttributes.RTSpecialName))
                    continue;

                var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                Fields.Add(field);
                field.DefaultValue = context.MetadataReader.GetConstantBytes(fieldDef.GetDefaultValue());
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

            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                for (var i = 0; i < Fields.Count; i++)
                {
                    var field = Fields[i];
                    context.Writer.Write(field);

                    if (field.DefaultValue != null)
                    {
                        if (field.DefaultValue.Length != 4)
                            throw new NotSupportedException();

                        var i32 = BitConverter.ToInt32(field.DefaultValue, 0);
                        context.Writer.Write(" = ");
                        context.Writer.Write(i32);
                    }
                    context.Writer.WriteLine(',');
                }
            });
        }
    }
}
