#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct BDA_TS_SELECTORINFO
{
    public byte bTSInfolength;
    public InlineArrayByte_2 bReserved;
    public Guid guidNetworkType;
    public byte bTSIDCount;
    public InlineArrayUInt16_1 usTSID; // variable-length array placeholder
}
