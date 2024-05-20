#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEPROPERTY
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public byte bType;
            public byte bReserved;
            public ushort usArrayIndex;
        }
        
        [FieldOffset(0)]
        public uint ulId;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public PWSTR pszName;
    public _Anonymous_e__Union Anonymous;
    public PWSTR pszValue;
    public VARIANT vValue;
    public uint ulFirstElement;
    public uint ulCountOfElements;
    public nint pNextSibling;
    public nint pFirstChild;
    public float SREngineConfidence;
    public sbyte Confidence;
}
