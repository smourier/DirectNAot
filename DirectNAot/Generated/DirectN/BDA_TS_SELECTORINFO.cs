#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TS_SELECTORINFO
{
    public byte bTSInfolength;
    public InlineArrayByte2 bReserved;
    public Guid guidNetworkType;
    public byte bTSIDCount;
    public InlineArrayUInt161 usTSID; // variable-length array placeholder
}
