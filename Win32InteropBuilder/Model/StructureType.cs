using System;

namespace Win32InteropBuilder.Model
{
    public class StructureType(FullName fullName) : BuilderType(fullName)
    {
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

                    context.Writer.WriteLine($"public {mapped.GetGeneratedName(context)} {field};");
                }
            });
        }
    }
}
