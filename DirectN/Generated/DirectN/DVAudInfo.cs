#nullable enable
namespace DirectN;

public partial struct DVAudInfo
{
    public InlineArrayByte_2 bAudStyle;
    public InlineArrayByte_2 bAudQu;
    public byte bNumAudPin;
    public InlineArrayUInt16_2 wAvgSamplesPerPinPerFrm;
    public ushort wBlkMode;
    public ushort wDIFMode;
    public ushort wBlkDiv;
}
