#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_rate_set_event
public partial struct MFP_RATE_SET_EVENT
{
    public MFP_EVENT_HEADER header;
    public nint pMediaItem;
    public float flRate;
}
