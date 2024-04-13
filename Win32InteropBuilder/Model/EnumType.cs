using System;

namespace Win32InteropBuilder.Model
{
    public class EnumType : BuilderType
    {
        public EnumType(FullName fullName)
            : base(fullName)
        {
        }

        public virtual bool IsFlags { get; set; }

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
