namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_halinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_HALINFO
{
    public uint dwSize;
    public VIDEOMEMORYINFO vmiData;
    public DDNTCORECAPS ddCaps;
    public nint GetDriverInfo;
    public uint dwFlags;
    public nint lpD3DGlobalDriverData;
    public nint lpD3DHALCallbacks;
    public nint lpD3DBufCallbacks;
}
