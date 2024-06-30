#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppstatussignalingcmddata
public partial struct DXVA_COPPStatusSignalingCmdData
{
    public Guid rApp;
    public uint dwFlags;
    public uint AvailableTVProtectionStandards;
    public uint ActiveTVProtectionStandard;
    public uint TVType;
    public uint AspectRatioValidMask1;
    public uint AspectRatioData1;
    public uint AspectRatioValidMask2;
    public uint AspectRatioData2;
    public uint AspectRatioValidMask3;
    public uint AspectRatioData3;
    public InlineArrayUInt32_4 ExtendedInfoValidMask;
    public InlineArrayUInt32_4 ExtendedInfoData;
}
