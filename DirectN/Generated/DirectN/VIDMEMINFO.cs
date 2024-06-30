#nullable enable
namespace DirectN;

public partial struct VIDMEMINFO
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
    public uint dwNumHeaps;
    public nint pvmList;
}
