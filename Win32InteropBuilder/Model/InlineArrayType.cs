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
    }
}
