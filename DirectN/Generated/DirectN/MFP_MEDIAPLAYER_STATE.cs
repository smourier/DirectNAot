#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ne-mfplay-mfp_mediaplayer_state
public enum MFP_MEDIAPLAYER_STATE
{
    MFP_MEDIAPLAYER_STATE_EMPTY = 0,
    MFP_MEDIAPLAYER_STATE_STOPPED = 1,
    MFP_MEDIAPLAYER_STATE_PLAYING = 2,
    MFP_MEDIAPLAYER_STATE_PAUSED = 3,
    MFP_MEDIAPLAYER_STATE_SHUTDOWN = 4,
}
