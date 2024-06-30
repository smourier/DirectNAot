#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_vpcaps
public partial struct DXVAHD_VPCAPS
{
    public Guid VPGuid;
    public uint PastFrames;
    public uint FutureFrames;
    public uint ProcessorCaps;
    public uint ITelecineCaps;
    public uint CustomRateCount;
}
