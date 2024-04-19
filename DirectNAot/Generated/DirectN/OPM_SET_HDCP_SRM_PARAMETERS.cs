namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_set_hdcp_srm_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_SET_HDCP_SRM_PARAMETERS
{
    public uint ulSRMVersion;
}
