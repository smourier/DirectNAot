#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_opm_status
public enum MF_MEDIA_ENGINE_OPM_STATUS
{
    MF_MEDIA_ENGINE_OPM_NOT_REQUESTED = 0,
    MF_MEDIA_ENGINE_OPM_ESTABLISHED = 1,
    MF_MEDIA_ENGINE_OPM_FAILED_VM = 2,
    MF_MEDIA_ENGINE_OPM_FAILED_BDA = 3,
    MF_MEDIA_ENGINE_OPM_FAILED_UNSIGNED_DRIVER = 4,
    MF_MEDIA_ENGINE_OPM_FAILED = 5,
}
