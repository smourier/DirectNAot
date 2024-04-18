namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddsurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSURFACEDATA
{
    public uint ddsCaps;
    public uint dwSurfaceOffset;
    public nuint fpLockPtr;
    public uint dwWidth;
    public uint dwHeight;
    public int lPitch;
    public uint dwOverlayFlags;
    public uint dwOverlayOffset;
    public uint dwOverlaySrcWidth;
    public uint dwOverlaySrcHeight;
    public uint dwOverlayDestWidth;
    public uint dwOverlayDestHeight;
    public uint dwVideoPortId;
    public uint dwFormatFlags;
    public uint dwFormatFourCC;
    public uint dwFormatBitCount;
    public uint dwRBitMask;
    public uint dwGBitMask;
    public uint dwBBitMask;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
    public uint dwDriverReserved4;
}
