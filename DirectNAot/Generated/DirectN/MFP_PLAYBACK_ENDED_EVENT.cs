#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_playback_ended_event
[StructLayout(LayoutKind.Sequential)]
public partial struct MFP_PLAYBACK_ENDED_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
}
