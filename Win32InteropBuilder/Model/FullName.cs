﻿using System;

namespace Win32InteropBuilder.Model
{
    public class FullName : IEquatable<FullName>, IComparable<FullName>, IComparable
    {
        public static FullName Invalid { get; } = new FullName("???", "???");
        public static FullName SystemIntPtr { get; } = new FullName(typeof(nint));
        public static FullName SystemValueType { get; } = new FullName(typeof(ValueType));
        public static FullName IUnknown { get; } = new("Windows.Win32.System.Com.IUnknown");
        public static FullName IDispatch { get; } = new("Windows.Win32.System.Com.IDispatch");
        public static FullName HRESULT { get; } = new("Windows.Win32.Foundation.HRESULT");
        public static FullName ConstAttribute { get; } = new("Windows.Win32.Foundation.Interop.ConstAttribute");
        public static FullName NativeTypedefAttribute { get; } = new("Windows.Win32.Foundation.Interop.NativeTypedefAttribute");
        public static FullName UnmanagedFunctionPointerAttribute { get; } = new("System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute");
        public static FullName GuidAttribute { get; } = new("Windows.Win32.Foundation.Metadata.GuidAttribute");

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

        public override string ToString() => $"{Namespace}.{Name}";
        public bool Equals(FullName? other) => other != null && other.Namespace == Namespace && other.Name == Name;
        public override bool Equals(object? obj) => Equals(obj as FullName);
        public override int GetHashCode() => Namespace.GetHashCode() ^ Name.GetHashCode();
        int IComparable.CompareTo(object? obj) => CompareTo(obj as FullName);
        public int CompareTo(FullName? other) { ArgumentNullException.ThrowIfNull(other); return ToString().CompareTo(other.ToString()); }

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