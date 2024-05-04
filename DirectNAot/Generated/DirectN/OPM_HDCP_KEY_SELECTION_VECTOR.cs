#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_hdcp_key_selection_vector
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_HDCP_KEY_SELECTION_VECTOR
{
    public InlineArrayByte5 abKeySelectionVector;
}
