#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WMDRMProtectionInfo
{
    public InlineArrayUInt1625 wszKID;
    public ulong qwCounter;
    public ulong qwIndex;
    public byte bOffset;
}
