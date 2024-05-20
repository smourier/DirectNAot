#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSVPMAXPIXELRATE
{
    public KS_AMVPSIZE Size;
    public uint MaxPixelsPerSecond;
    public uint Reserved;
}
