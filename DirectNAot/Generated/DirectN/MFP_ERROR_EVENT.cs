namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_error_event
[StructLayout(LayoutKind.Sequential)]
public partial struct MFP_ERROR_EVENT
{
    public MFP_EVENT_HEADER header;
}
