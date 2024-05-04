#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_stereomode
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_STEREOMODE
{
    public uint dwSize;
    public uint dwHeight;
    public uint dwWidth;
    public uint dwBpp;
    public uint dwRefreshRate;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bSupported;
}
