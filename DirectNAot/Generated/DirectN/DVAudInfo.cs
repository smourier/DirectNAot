#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DVAudInfo
{
    public InlineArrayByte2 bAudStyle;
    public InlineArrayByte2 bAudQu;
    public byte bNumAudPin;
    public InlineArrayUInt162 wAvgSamplesPerPinPerFrm;
    public ushort wBlkMode;
    public ushort wDIFMode;
    public ushort wBlkDiv;
}
