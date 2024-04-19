namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SYNCSURFACEDATA
{
    public uint dwSize;
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwSurfaceOffset;
    public nuint fpLockPtr;
    public int lPitch;
    public uint dwOverlayOffset;
    public uint dwOverlaySrcWidth;
    public uint dwOverlaySrcHeight;
    public uint dwOverlayDestWidth;
    public uint dwOverlayDestHeight;
    public nuint dwDriverReserved1;
    public nuint dwDriverReserved2;
    public nuint dwDriverReserved3;
    public HRESULT ddRVal;
}
