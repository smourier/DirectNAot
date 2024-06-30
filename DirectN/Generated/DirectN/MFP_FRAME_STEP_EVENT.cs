#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_frame_step_event
public partial struct MFP_FRAME_STEP_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
}
