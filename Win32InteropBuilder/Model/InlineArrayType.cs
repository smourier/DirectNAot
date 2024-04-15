using System;

namespace Win32InteropBuilder.Model
{
    public class InlineArrayType : StructureType
    {
        public InlineArrayType(BuilderType elementType, int size)
            : base(new FullName(GeneratedInteropNamespace + ".InlineArray" + elementType?.FullName.Name + size))
        {
            ArgumentNullException.ThrowIfNull(elementType);
            ElementType = elementType;
            Size = size;
        }

        public BuilderType ElementType { get; protected set; }
        public int Size { get; protected set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is InlineArrayType typed)
            {
                typed.ElementType = ElementType;
                typed.Size = Size;
            }
        }

        protected override void GenerateTypeCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            context.Writer.WriteLine($"[InlineArray({Size})]");
            context.Writer.WriteLine($"public partial struct {FullName.Name}");
            context.Writer.WithParens(() =>
            {
                context.Writer.WriteLine($"public {ElementType.GetGeneratedName(context)} Data;");
            });
        }
    }
}
