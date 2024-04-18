namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_FLIPTOGDISURFACEDATA
{
    public nint lpDD;
    public uint dwToGDI;
    public uint dwReserved;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint FlipToGDISurface;
}
