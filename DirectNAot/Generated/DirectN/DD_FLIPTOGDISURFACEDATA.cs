namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_fliptogdisurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_FLIPTOGDISURFACEDATA
{
    public nint lpDD;
    public uint dwToGDI;
    public uint dwReserved;
    public HRESULT ddRVal;
    public nint FlipToGDISurface;
}
