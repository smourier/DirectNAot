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

        public virtual BuilderType ElementType { get; protected set; }
        public virtual int Size { get; protected set; }
        public virtual string? ElementName { get; set; }

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
