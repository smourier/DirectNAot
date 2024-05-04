#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_set_acp_and_cgmsa_signaling_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS
{
    public uint ulNewTVProtectionStandard;
    public uint ulAspectRatioChangeMask1;
    public uint ulAspectRatioData1;
    public uint ulAspectRatioChangeMask2;
    public uint ulAspectRatioData2;
    public uint ulAspectRatioChangeMask3;
    public uint ulAspectRatioData3;
    public InlineArrayUInt324 ulReserved;
    public InlineArrayUInt324 ulReserved2;
    public uint ulReserved3;
}
