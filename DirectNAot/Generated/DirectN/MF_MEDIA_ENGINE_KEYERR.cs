#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_keyerr
public enum MF_MEDIA_ENGINE_KEYERR
{
    MF_MEDIAENGINE_KEYERR_UNKNOWN = 1,
    MF_MEDIAENGINE_KEYERR_CLIENT = 2,
    MF_MEDIAENGINE_KEYERR_SERVICE = 3,
    MF_MEDIAENGINE_KEYERR_OUTPUT = 4,
    MF_MEDIAENGINE_KEYERR_HARDWARECHANGE = 5,
    MF_MEDIAENGINE_KEYERR_DOMAIN = 6,
}
