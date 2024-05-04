#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/ne-contentpartner-wmppartnernotification
public enum WMPPartnerNotification
{
    wmpsnBackgroundProcessingBegin = 1,
    wmpsnBackgroundProcessingEnd = 2,
    wmpsnCatalogDownloadFailure = 3,
    wmpsnCatalogDownloadComplete = 4,
}
