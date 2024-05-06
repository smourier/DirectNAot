#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public InlineArrayUInt32_2 ReservedNT;
    public InlineArrayByte_6 TitleKey;
    public InlineArrayByte_2 Reserved;
}
