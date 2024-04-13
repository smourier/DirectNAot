using System;

namespace Win32InteropBuilder.Model
{
    public class InlineArrayType : StructureType
    {
        public InlineArrayType(BuilderType elementType, int size)
            : base(new FullName("InteropSupport." + elementType?.FullName.Name + "Array" + size))
        {
            ArgumentNullException.ThrowIfNull(elementType);
            ElementType = elementType;
            Size = size;
        }

        public BuilderType ElementType { get; }
        public int Size { get; }

        protected override void GenerateTypeCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            context.Writer.WriteLine($"[InlineArray({Size})]");
            context.Writer.WriteLine($"public partial struct {FullName.Name}");
            context.Writer.WithParens(() =>
            {
                context.Writer.WriteLine($"public {ElementType.GetGeneratedName(context.Namespace)} Data;");
            });
        }
    }
}
