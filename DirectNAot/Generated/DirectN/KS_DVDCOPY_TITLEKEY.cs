#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public InlineArrayUInt322 ReservedNT;
    public InlineArrayByte6 TitleKey;
    public InlineArrayByte2 Reserved;
}
