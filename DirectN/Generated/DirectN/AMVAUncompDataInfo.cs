#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvauncompdatainfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVAUncompDataInfo
{
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
}
