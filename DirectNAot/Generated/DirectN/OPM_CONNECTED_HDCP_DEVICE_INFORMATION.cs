#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_connected_hdcp_device_information
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_CONNECTED_HDCP_DEVICE_INFORMATION
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public uint ulStatusFlags;
    public uint ulHDCPFlags;
    public OPM_HDCP_KEY_SELECTION_VECTOR ksvB;
    public InlineArrayByte11 Reserved;
    public InlineArrayByte16 Reserved2;
    public InlineArrayByte16 Reserved3;
}
