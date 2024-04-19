namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_fixed32
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_Fixed32
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public ushort Fraction;
            public short Value;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public int ll;
    }
    
    public _Anonymous_e__Union Anonymous;
}
