#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/ne-photoacquire-error_advise_result
public enum ERROR_ADVISE_RESULT
{
    PHOTOACQUIRE_RESULT_YES = 0,
    PHOTOACQUIRE_RESULT_NO = 1,
    PHOTOACQUIRE_RESULT_OK = 2,
    PHOTOACQUIRE_RESULT_SKIP = 3,
    PHOTOACQUIRE_RESULT_SKIP_ALL = 4,
    PHOTOACQUIRE_RESULT_RETRY = 5,
    PHOTOACQUIRE_RESULT_ABORT = 6,
}
