#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/ne-photoacquire-error_advise_message_type
public enum ERROR_ADVISE_MESSAGE_TYPE
{
    PHOTOACQUIRE_ERROR_SKIPRETRYCANCEL = 0,
    PHOTOACQUIRE_ERROR_RETRYCANCEL = 1,
    PHOTOACQUIRE_ERROR_YESNO = 2,
    PHOTOACQUIRE_ERROR_OK = 3,
}
