namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_protection_flags
public enum MF_MEDIA_ENGINE_PROTECTION_FLAGS
{
    MF_MEDIA_ENGINE_ENABLE_PROTECTED_CONTENT = 1,
    MF_MEDIA_ENGINE_USE_PMP_FOR_ALL_CONTENT = 2,
    MF_MEDIA_ENGINE_USE_UNPROTECTED_PMP = 4,
}
