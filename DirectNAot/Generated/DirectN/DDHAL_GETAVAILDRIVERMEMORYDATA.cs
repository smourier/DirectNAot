namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETAVAILDRIVERMEMORYDATA
{
    public nint lpDD;
    public DDSCAPS DDSCaps;
    public uint dwTotal;
    public uint dwFree;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetAvailDriverMemory;
    public DDSCAPSEX ddsCapsEx;
}
