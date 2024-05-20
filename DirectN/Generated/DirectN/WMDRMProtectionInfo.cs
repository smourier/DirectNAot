#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WMDRMProtectionInfo
{
    public InlineArrayUInt16_25 wszKID;
    public ulong qwCounter;
    public ulong qwIndex;
    public byte bOffset;
}
