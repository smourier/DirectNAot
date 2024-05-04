#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_pause_event
[StructLayout(LayoutKind.Sequential)]
public partial struct MFP_PAUSE_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
}
