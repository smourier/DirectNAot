#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_timed_text_error_code
public enum MF_TIMED_TEXT_ERROR_CODE
{
    MF_TIMED_TEXT_ERROR_CODE_NOERROR = 0,
    MF_TIMED_TEXT_ERROR_CODE_FATAL = 1,
    MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT = 2,
    MF_TIMED_TEXT_ERROR_CODE_NETWORK = 3,
    MF_TIMED_TEXT_ERROR_CODE_INTERNAL = 4,
}
