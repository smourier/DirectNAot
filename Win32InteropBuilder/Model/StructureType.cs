using System;
using System.CodeDom.Compiler;

namespace Win32InteropBuilder.Model
{
    public class StructureType : BuilderType
    {
        public StructureType(FullName fullName)
            : base(fullName)
        {
        }


        protected override void GenerateTypeCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
            writer.WriteLine("[StructLayout(LayoutKind.Sequential)]");
            writer.Write($"public partial struct {FullName.Name}");
            //if (BaseType != null)
            //    throw new NotSupportedException();

            writer.WriteLine();
            writer.WithParens(() =>
            {
            });
        }
    }
}
