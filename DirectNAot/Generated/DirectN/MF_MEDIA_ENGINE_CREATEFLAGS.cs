#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_createflags
public enum MF_MEDIA_ENGINE_CREATEFLAGS
{
    MF_MEDIA_ENGINE_AUDIOONLY = 1,
    MF_MEDIA_ENGINE_WAITFORSTABLE_STATE = 2,
    MF_MEDIA_ENGINE_FORCEMUTE = 4,
    MF_MEDIA_ENGINE_REAL_TIME_MODE = 8,
    MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 16,
    MF_MEDIA_ENGINE_CREATEFLAGS_MASK = 31,
}
