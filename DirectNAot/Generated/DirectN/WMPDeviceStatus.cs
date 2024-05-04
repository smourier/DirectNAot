#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpdevicestatus
public enum WMPDeviceStatus
{
    wmpdsUnknown = 0,
    wmpdsPartnershipExists = 1,
    wmpdsPartnershipDeclined = 2,
    wmpdsPartnershipAnother = 3,
    wmpdsManualDevice = 4,
    wmpdsNewDevice = 5,
    wmpdsLast = 6,
}
