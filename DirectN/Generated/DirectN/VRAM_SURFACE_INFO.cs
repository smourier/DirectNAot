#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VRAM_SURFACE_INFO
{
    public nuint hSurface;
    public long VramPhysicalAddress;
    public uint cbCaptured;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwLinearSize;
    public int lPitch;
    public InlineArrayUInt64_16 ullReserved;
}
