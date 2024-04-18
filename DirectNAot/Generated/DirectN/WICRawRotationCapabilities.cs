namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicrawrotationcapabilities
public enum WICRawRotationCapabilities
{
    WICRawRotationCapabilityNotSupported = 0,
    WICRawRotationCapabilityGetSupported = 1,
    WICRawRotationCapabilityNinetyDegreesSupported = 2,
    WICRawRotationCapabilityFullySupported = 3,
}
