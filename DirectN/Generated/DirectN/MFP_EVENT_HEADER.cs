#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ns-mfplay-mfp_event_header
public partial struct MFP_EVENT_HEADER
{
    public MFP_EVENT_TYPE eEventType;
    public HRESULT hrEvent;
    public nint pMediaPlayer;
    public MFP_MEDIAPLAYER_STATE eState;
    public nint pPropertyStore;
}
