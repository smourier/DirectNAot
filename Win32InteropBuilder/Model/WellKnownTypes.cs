using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Model
{
    public static class WellKnownTypes
    {
        public static BuilderType SystemBoolean { get; } = new(typeof(bool)) { GeneratedName = "bool", IsGenerated = false, UnmanagedType = UnmanagedType.U4 };
        public static BuilderType SystemByte { get; } = new(typeof(byte)) { GeneratedName = "byte", IsGenerated = false };
        public static BuilderType SystemChar { get; } = new(typeof(char)) { GeneratedName = "char", IsGenerated = false };
        public static BuilderType SystemDouble { get; } = new(typeof(double)) { GeneratedName = "double", IsGenerated = false };
        public static BuilderType SystemGuid { get; } = new(typeof(Guid)) { IsGenerated = false };
        public static BuilderType SystemInt16 { get; } = new(typeof(short)) { GeneratedName = "short", IsGenerated = false };
        public static BuilderType SystemInt32 { get; } = new(typeof(int)) { GeneratedName = "int", IsGenerated = false };
        public static BuilderType SystemInt64 { get; } = new(typeof(long)) { GeneratedName = "long", IsGenerated = false };
        public static BuilderType SystemIntPtr { get; } = new(typeof(nint)) { GeneratedName = "nint", IsGenerated = false };
        public static BuilderType SystemSByte { get; } = new(typeof(sbyte)) { GeneratedName = "sbyte", IsGenerated = false };
        public static BuilderType SystemSingle { get; } = new(typeof(float)) { GeneratedName = "float", IsGenerated = false };
        public static BuilderType SystemString { get; } = new(typeof(string)) { GeneratedName = "string", IsGenerated = false };
        public static BuilderType SystemUInt16 { get; } = new(typeof(ushort)) { GeneratedName = "ushort", IsGenerated = false };
        public static BuilderType SystemUInt32 { get; } = new(typeof(uint)) { GeneratedName = "uint", IsGenerated = false };
        public static BuilderType SystemUInt64 { get; } = new(typeof(ulong)) { GeneratedName = "ulong", IsGenerated = false };
        public static BuilderType SystemUIntPtr { get; } = new(typeof(nuint)) { GeneratedName = "nuint", IsGenerated = false };
        public static BuilderType SystemVoid { get; } = new(typeof(void)) { GeneratedName = "nint", IsGenerated = false };

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
