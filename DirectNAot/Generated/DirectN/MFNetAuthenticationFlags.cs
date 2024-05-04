#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfnetauthenticationflags
public enum MFNetAuthenticationFlags
{
    MFNET_AUTHENTICATION_PROXY = 1,
    MFNET_AUTHENTICATION_CLEAR_TEXT = 2,
    MFNET_AUTHENTICATION_LOGGED_ON_USER = 4,
}
