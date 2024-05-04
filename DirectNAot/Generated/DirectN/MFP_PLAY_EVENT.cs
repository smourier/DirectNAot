#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_play_event
[StructLayout(LayoutKind.Sequential)]
public partial struct MFP_PLAY_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
}
