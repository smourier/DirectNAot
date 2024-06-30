#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-videomemoryinfo
public partial struct VIDEOMEMORYINFO
{
    public nuint fpPrimary;
    public uint dwFlags;
    public uint dwDisplayWidth;
    public uint dwDisplayHeight;
    public int lDisplayPitch;
    public DDPIXELFORMAT ddpfDisplay;
    public uint dwOffscreenAlign;
    public uint dwOverlayAlign;
    public uint dwTextureAlign;
    public uint dwZBufferAlign;
    public uint dwAlphaAlign;
    public nint pvPrimary;
}
