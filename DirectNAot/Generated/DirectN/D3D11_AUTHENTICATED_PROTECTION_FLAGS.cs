namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_protection_flags
[StructLayout(LayoutKind.Explicit)]
public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Flags_e__Struct
    {
        public uint _bitfield;
    }
    
    [FieldOffset(0)]
    public _Flags_e__Struct Flags;
    
    [FieldOffset(0)]
    public uint Value;
}
