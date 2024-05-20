#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_preload
public enum MF_MEDIA_ENGINE_PRELOAD
{
    MF_MEDIA_ENGINE_PRELOAD_MISSING = 0,
    MF_MEDIA_ENGINE_PRELOAD_EMPTY = 1,
    MF_MEDIA_ENGINE_PRELOAD_NONE = 2,
    MF_MEDIA_ENGINE_PRELOAD_METADATA = 3,
    MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC = 4,
}
