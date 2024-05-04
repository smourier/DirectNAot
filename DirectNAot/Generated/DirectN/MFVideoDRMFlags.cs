#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mfvideodrmflags
public enum MFVideoDRMFlags
{
    MFVideoDRMFlag_None = 0,
    MFVideoDRMFlag_AnalogProtected = 1,
    MFVideoDRMFlag_DigitallyProtected = 2,
}
