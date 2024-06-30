#nullable enable
namespace DirectN;

public partial struct BDA_WMDRM_STATUS
{
    public int lResult;
    public uint ulMaxCaptureTokenSize;
    public uint uMaxStreamingPid;
    public uint ulMaxLicense;
    public uint ulMinSecurityLevel;
    public uint ulRevInfoSequenceNumber;
    public ulong ulRevInfoIssuedTime;
    public uint ulRevListVersion;
    public uint ulRevInfoTTL;
    public uint ulState;
}
