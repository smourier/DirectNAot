#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHALMODEINFO
{
    public uint dwWidth;
    public uint dwHeight;
    public int lPitch;
    public uint dwBPP;
    public ushort wFlags;
    public ushort wRefreshRate;
    public uint dwRBitMask;
    public uint dwGBitMask;
    public uint dwBBitMask;
    public uint dwAlphaBitMask;
}
