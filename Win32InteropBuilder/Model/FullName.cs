using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Model
{
    public class FullName : IEquatable<FullName>, IComparable<FullName>, IComparable
    {
        public const char NestedTypesSeparator = '+';

        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/classes#154-constants
        private static readonly ConcurrentBag<FullName> _constableTypes =
        [
            WellKnownTypes.SystemSByte.FullName,
            WellKnownTypes.SystemByte.FullName,
            WellKnownTypes.SystemInt16.FullName,
            WellKnownTypes.SystemUInt16.FullName,
            WellKnownTypes.SystemInt32.FullName,
            WellKnownTypes.SystemUInt32.FullName,
            WellKnownTypes.SystemInt64.FullName,
            WellKnownTypes.SystemUInt64.FullName,
            WellKnownTypes.SystemChar.FullName,
            WellKnownTypes.SystemSingle.FullName,
            WellKnownTypes.SystemDouble.FullName,
            WellKnownTypes.SystemDecimal.FullName,
            WellKnownTypes.SystemBoolean.FullName,
            WellKnownTypes.SystemString.FullName,
        ];

        public static FullName SystemIntPtr { get; } = new(typeof(nint));
        public static FullName SystemValueType { get; } = new(typeof(ValueType));
        public static FullName SystemEnum { get; } = new(typeof(Enum));
        public static FullName IUnknown { get; } = new("Windows.Win32.System.Com.IUnknown");
        public static FullName IDispatch { get; } = new("Windows.Win32.System.Com.IDispatch");
        public static FullName HRESULT { get; } = new("Windows.Win32.Foundation.HRESULT");
        public static FullName BOOL { get; } = new("Windows.Win32.Foundation.BOOL");
        public static FullName NativeTypedefAttribute { get; } = new("Windows.Win32.Foundation.Metadata.NativeTypedefAttribute");
        public static FullName DocumentationAttribute { get; } = new("Windows.Win32.Foundation.Metadata.DocumentationAttribute");
        public static FullName ComOutPtrAttribute { get; } = new("Windows.Win32.Foundation.Metadata.ComOutPtrAttribute");
        public static FullName ConstAttribute { get; } = new("Windows.Win32.Foundation.Metadata.ConstAttribute");
        public static FullName SupportedOSPlatformAttribute { get; } = new("Windows.Win32.Foundation.Metadata.SupportedOSPlatformAttribute");
        public static FullName SupportedArchitectureAttribute { get; } = new("Windows.Win32.Foundation.Metadata.SupportedArchitectureAttribute");
        public static FullName GuidAttribute { get; } = new("Windows.Win32.Foundation.Metadata.GuidAttribute");
        public static FullName AnsiAttribute { get; } = new("Windows.Win32.Foundation.Metadata.AnsiAttribute");
        public static FullName UnicodeAttribute { get; } = new("Windows.Win32.Foundation.Metadata.UnicodeAttribute");
        //public static FullName OutAttribute { get; } = new(typeof(OutAttribute));
        //public static FullName InAttribute { get; } = new(typeof(InAttribute));
        public static FullName UnmanagedFunctionPointerAttribute { get; } = new(typeof(UnmanagedFunctionPointerAttribute));
        public static FullName MulticastDelegate { get; } = new(typeof(MulticastDelegate));

        public FullName(string @namespace, string name)
        {
            ArgumentNullException.ThrowIfNull(@namespace);
            ArgumentNullException.ThrowIfNull(name);
            Namespace = @namespace;
            Name = name;
        }

        public FullName(string fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            var pos = fullName.LastIndexOf('.');
            if (pos < 0)
            {
                Name = fullName;
                Namespace = string.Empty;
            }
            else
            {
                Name = fullName[(pos + 1)..];
                Namespace = fullName[..pos];
            }
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
        public string? NestedName
        {
            get
            {
                var pos = Name.LastIndexOf(NestedTypesSeparator);
                if (pos < 0)
                    return null;

                return Name[(pos + 1)..];
            }
        }

        public virtual string GetRelativeTo(FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            if (Namespace == fullName.Namespace)
                return Name;

            return ToString();
        }

        public override string ToString() => $"{Namespace}.{Name}";
        public bool Equals(FullName? other) => other != null && other.Namespace == Namespace && other.Name == Name;
        public override bool Equals(object? obj) => Equals(obj as FullName);
        public override int GetHashCode() => Namespace.GetHashCode() ^ Name.GetHashCode();
        int IComparable.CompareTo(object? obj) => CompareTo(obj as FullName);
        public int CompareTo(FullName? other) { ArgumentNullException.ThrowIfNull(other); return ToString().CompareTo(other.ToString()); }

        public static bool IsConstableType(FullName fullName) => _constableTypes.Contains(fullName);

        public static bool operator !=(FullName? obj1, FullName? obj2) => !(obj1 == obj2);
        public static bool operator ==(FullName? obj1, FullName? obj2)
        {
            if (ReferenceEquals(obj1, obj2))
                return true;

            if (obj1 is null)
                return false;

            if (obj2 is null)
                return false;

            return obj1.Equals(obj2);
        }
    }
}
