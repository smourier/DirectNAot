#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_syncsurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SYNCSURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwSurfaceOffset;
    public nuint fpLockPtr;
    public int lPitch;
    public uint dwOverlayOffset;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
    public uint dwDriverReserved4;
    public HRESULT ddRVal;
}
