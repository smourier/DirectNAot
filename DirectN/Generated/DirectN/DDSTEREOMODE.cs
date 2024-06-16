#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDSTEREOMODE
{
    public uint dwSize;
    public uint dwHeight;
    public uint dwWidth;
    public uint dwBpp;
    public uint dwRefreshRate;
    public BOOL bSupported;
}
