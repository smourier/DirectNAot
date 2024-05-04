#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_ready
public enum MF_MEDIA_ENGINE_READY
{
    MF_MEDIA_ENGINE_READY_HAVE_NOTHING = 0,
    MF_MEDIA_ENGINE_READY_HAVE_METADATA = 1,
    MF_MEDIA_ENGINE_READY_HAVE_CURRENT_DATA = 2,
    MF_MEDIA_ENGINE_READY_HAVE_FUTURE_DATA = 3,
    MF_MEDIA_ENGINE_READY_HAVE_ENOUGH_DATA = 4,
}
