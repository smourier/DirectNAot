namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHALINFO
{
    public uint dwSize;
    public nint lpDDCallbacks;
    public nint lpDDSurfaceCallbacks;
    public nint lpDDPaletteCallbacks;
    public VIDMEMINFO vmiData;
    public DDCORECAPS ddCaps;
    public uint dwMonitorFrequency;
    public nint GetDriverInfo;
    public uint dwModeIndex;
    public nint lpdwFourCC;
    public uint dwNumModes;
    public nint lpModeInfo;
    public uint dwFlags;
    public nint lpPDevice;
    public uint hInstance;
    public nuint lpD3DGlobalDriverData;
    public nuint lpD3DHALCallbacks;
    public nint lpDDExeBufCallbacks;
}
