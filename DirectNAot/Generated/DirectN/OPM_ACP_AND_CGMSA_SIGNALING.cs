namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_acp_and_cgmsa_signaling
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_ACP_AND_CGMSA_SIGNALING
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint ulStatusFlags;
    public uint ulAvailableTVProtectionStandards;
    public uint ulActiveTVProtectionStandard;
    public uint ulReserved;
    public uint ulAspectRatioValidMask1;
    public uint ulAspectRatioData1;
    public uint ulAspectRatioValidMask2;
    public uint ulAspectRatioData2;
    public uint ulAspectRatioValidMask3;
    public uint ulAspectRatioData3;
    public InlineArrayUInt324 ulReserved2;
    public InlineArrayUInt324 ulReserved3;
}
