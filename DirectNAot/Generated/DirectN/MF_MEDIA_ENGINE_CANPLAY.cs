#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_canplay
public enum MF_MEDIA_ENGINE_CANPLAY
{
    MF_MEDIA_ENGINE_CANPLAY_NOT_SUPPORTED = 0,
    MF_MEDIA_ENGINE_CANPLAY_MAYBE = 1,
    MF_MEDIA_ENGINE_CANPLAY_PROBABLY = 2,
}
