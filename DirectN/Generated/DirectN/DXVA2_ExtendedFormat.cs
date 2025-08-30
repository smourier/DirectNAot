#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_extendedformat
public partial struct DXVA2_ExtendedFormat
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint value;
    }
    
    public _Anonymous_e__Union Anonymous;
}
