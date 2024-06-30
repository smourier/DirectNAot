#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_mf_event
public partial struct MFP_MF_EVENT
{
    public MFP_EVENT_HEADER header;
    public uint MFEventType;
    public nint pMFMediaEvent;
    public nint pMediaItem;
}
