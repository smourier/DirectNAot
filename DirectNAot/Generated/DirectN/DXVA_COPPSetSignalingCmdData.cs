#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppsetsignalingcmddata
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPSetSignalingCmdData
{
    public uint ActiveTVProtectionStandard;
    public uint AspectRatioChangeMask1;
    public uint AspectRatioData1;
    public uint AspectRatioChangeMask2;
    public uint AspectRatioData2;
    public uint AspectRatioChangeMask3;
    public uint AspectRatioData3;
    public InlineArrayUInt324 ExtendedInfoChangeMask;
    public InlineArrayUInt324 ExtendedInfoData;
    public uint Reserved;
}
