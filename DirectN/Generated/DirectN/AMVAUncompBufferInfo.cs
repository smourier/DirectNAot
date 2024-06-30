#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvauncompbufferinfo
public partial struct AMVAUncompBufferInfo
{
    public uint dwMinNumSurfaces;
    public uint dwMaxNumSurfaces;
    public DDPIXELFORMAT ddUncompPixelFormat;
}
