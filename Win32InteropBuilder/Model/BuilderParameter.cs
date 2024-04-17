using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Model
{
    public class BuilderParameter : IComparable, IComparable<BuilderParameter>, IDocumentable
    {
        public BuilderParameter(string name, int sequenceNumber)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            SequenceNumber = sequenceNumber;
        }

        public string Name { get; }
        public int SequenceNumber { get; }
        public virtual ParameterAttributes Attributes { get; set; }
        public virtual BuilderType? Type { get; set; }
        public virtual bool IsComOutPtr { get; set; }
        public virtual string? Documentation { get; set; }
        public virtual UnmanagedType? UnmanagedType { get; set; }

        public virtual void GeneratedCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            if (Type == null)
                throw new InvalidOperationException();

            var mapped = context.MapType(Type);
            if (UnmanagedType.HasValue)
            {
                context.CurrentWriter.Write($"[MarshalAs(UnmanagedType.{UnmanagedType.Value})]");
            }
            else if (mapped.UnmanagedType.HasValue)
            {
                context.CurrentWriter.Write($"[MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
            }


            if (Attributes.HasFlag(ParameterAttributes.Out))
            {
                context.CurrentWriter.Write("out ");
            }

            context.CurrentWriter.Write(mapped.GetGeneratedName(context));
            context.CurrentWriter.Write(' ');
            context.CurrentWriter.Write(Name);
        }

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderParameter);
        public int CompareTo(BuilderParameter? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return SequenceNumber.CompareTo(other.SequenceNumber);
        }

        public override string ToString() => $"{Type} {Name}";
    }
}
