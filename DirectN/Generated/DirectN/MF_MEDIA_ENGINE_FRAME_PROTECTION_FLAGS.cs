#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_frame_protection_flags
public enum MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS
{
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_PROTECTED = 1,
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_SURFACE_PROTECTION = 2,
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_ANTI_SCREEN_SCRAPE_PROTECTION = 4,
}
