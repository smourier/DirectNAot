using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Model
{
    public static class WellKnownTypes
    {
        public static BuilderType SystemBoolean { get; } = new(typeof(bool)) { GeneratedName = "bool", IsGenerated = false, UnmanagedType = UnmanagedType.U4, PrimitiveTypeCode = PrimitiveTypeCode.Boolean };
        public static BuilderType SystemByte { get; } = new(typeof(byte)) { GeneratedName = "byte", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Byte };
        public static BuilderType SystemChar { get; } = new(typeof(char)) { GeneratedName = "char", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Char };
        public static BuilderType SystemDouble { get; } = new(typeof(double)) { GeneratedName = "double", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Double };
        public static BuilderType SystemDecimal { get; } = new(typeof(decimal)) { GeneratedName = "decimal", IsGenerated = false };
        public static BuilderType SystemEnum { get; } = new(typeof(Enum)) { IsGenerated = false };
        public static BuilderType SystemGuid { get; } = new(typeof(Guid)) { IsGenerated = false };
        public static BuilderType SystemInt16 { get; } = new(typeof(short)) { GeneratedName = "short", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Int16 };
        public static BuilderType SystemInt32 { get; } = new(typeof(int)) { GeneratedName = "int", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Int32 };
        public static BuilderType SystemInt64 { get; } = new(typeof(long)) { GeneratedName = "long", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Int64 };
        public static BuilderType SystemIntPtr { get; } = new(typeof(nint)) { GeneratedName = "nint", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.IntPtr };
        public static BuilderType SystemMulticastDelegate { get; } = new(typeof(MulticastDelegate)) { IsGenerated = false };
        public static BuilderType SystemObject { get; } = new(typeof(object)) { GeneratedName = "object", IsGenerated = false };
        public static BuilderType SystemSByte { get; } = new(typeof(sbyte)) { GeneratedName = "sbyte", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.SByte };
        public static BuilderType SystemSingle { get; } = new(typeof(float)) { GeneratedName = "float", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.Single };
        public static BuilderType SystemString { get; } = new(typeof(string)) { GeneratedName = "string", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.String };
        public static BuilderType SystemUInt16 { get; } = new(typeof(ushort)) { GeneratedName = "ushort", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.UInt16 };
        public static BuilderType SystemUInt32 { get; } = new(typeof(uint)) { GeneratedName = "uint", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.UInt32 };
        public static BuilderType SystemUInt64 { get; } = new(typeof(ulong)) { GeneratedName = "ulong", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.UInt64 };
        public static BuilderType SystemUIntPtr { get; } = new(typeof(nuint)) { GeneratedName = "nuint", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.UIntPtr };
        public static BuilderType SystemValueType { get; } = new(typeof(ValueType)) { IsGenerated = false };
        public static BuilderType SystemVoid { get; } = new(typeof(void)) { GeneratedName = "nint", IsGenerated = false, PrimitiveTypeCode = PrimitiveTypeCode.IntPtr };

        // *warning* this must come *after* definitions of static BuilderType above
        public static IDictionary<FullName, BuilderType> All => _all.Value;
        private static readonly Lazy<IDictionary<FullName, BuilderType>> _all = new(LoadAll);
        private static IDictionary<FullName, BuilderType> LoadAll
        {
            get
            {
                var dic = new ConcurrentDictionary<FullName, BuilderType>();
                foreach (var prop in typeof(WellKnownTypes).GetProperties(BindingFlags.Static | BindingFlags.Public).Where(p => p.PropertyType == typeof(BuilderType)))
                {
                    var type = (BuilderType)prop.GetValue(null)!;
                    dic[type.FullName] = type;
                }
                return dic;
            }
        }
    }
}
