#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/ne-contentpartner-wmpcallbacknotification
public enum WMPCallbackNotification
{
    wmpcnLoginStateChange = 1,
    wmpcnAuthResult = 2,
    wmpcnLicenseUpdated = 3,
    wmpcnNewCatalogAvailable = 4,
    wmpcnNewPluginAvailable = 5,
    wmpcnDisableRadioSkipping = 6,
}
