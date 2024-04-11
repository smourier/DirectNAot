using System;

namespace Win32MetadataReader
{
    public class FullName : IEquatable<FullName>
    {
        public static FullName Invalid { get; } = new FullName("???", "???");
        public static FullName SystemIntPtr { get; } = new FullName(typeof(nint));
        public static FullName SystemValueType { get; } = new FullName(typeof(ValueType));
        public static FullName IUnknown { get; } = new("Windows.Win32.System.Com", "IUnknown");
        public static FullName IDispatch { get; } = new("Windows.Win32.System.Com", "IDispatch");
        public static FullName HRESULT { get; } = new("Windows.Win32.Foundation", "HRESULT");
        public static FullName ConstAttribute { get; } = new("Windows.Win32.Foundation.Interop", "ConstAttribute");
        public static FullName NativeTypedefAttribute { get; } = new("Windows.Win32.Foundation.Interop", "NativeTypedefAttribute");
        public static FullName UnmanagedFunctionPointerAttribute { get; } = new("System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute");
        public static FullName GuidAttribute { get; } = new("Windows.Win32.Foundation.Metadata", "GuidAttribute");

        public FullName(string @namespace, string name)
        {
            ArgumentNullException.ThrowIfNull(@namespace);
            ArgumentNullException.ThrowIfNull(name);
            Namespace = @namespace;
            Name = name;
        }

        public FullName(Type type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (type.Name == null)
                throw new ArgumentException(null, nameof(type));

            if (type.Namespace == null)
                throw new ArgumentException(null, nameof(type));

            Namespace = type.Namespace;
            Name = type.Name;
        }

        public string Namespace { get; }
        public string Name { get; }

        public bool Equals(FullName? other) => other != null && other.Namespace == Namespace && other.Name == Name;
        public override bool Equals(object? obj) => Equals(obj as FullName);
        public override int GetHashCode() => Namespace.GetHashCode() ^ Name.GetHashCode();

        public override string ToString() => $"{Namespace}.{Name}";
    }
}
