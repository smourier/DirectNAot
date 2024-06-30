#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppsetsignalingcmddata
public partial struct DXVA_COPPSetSignalingCmdData
{
    public uint ActiveTVProtectionStandard;
    public uint AspectRatioChangeMask1;
    public uint AspectRatioData1;
    public uint AspectRatioChangeMask2;
    public uint AspectRatioData2;
    public uint AspectRatioChangeMask3;
    public uint AspectRatioData3;
    public InlineArrayUInt32_4 ExtendedInfoChangeMask;
    public InlineArrayUInt32_4 ExtendedInfoData;
    public uint Reserved;
}
