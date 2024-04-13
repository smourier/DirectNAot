using System;

namespace Win32InteropBuilder.Model
{
    public class StructureType : BuilderType
    {
        public StructureType(FullName fullName)
            : base(fullName)
        {
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
                    if (field.Type.UnmanagedType.HasValue)
                    {
                        context.Writer.WriteLine($"[MarshalAs(UnmanagedType.{field.Type.UnmanagedType.Value})]");
                    }

                    context.Writer.Write("public ");
                    context.Writer.Write(field.Type.GetGeneratedName(context));
                    context.Writer.Write(' ');
                    context.Writer.Write(field);
                    context.Writer.WriteLine(';');
                }
            });
        }
    }
}
