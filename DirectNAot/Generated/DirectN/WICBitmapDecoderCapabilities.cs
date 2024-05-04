#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmapdecodercapabilities
public enum WICBitmapDecoderCapabilities
{
    WICBitmapDecoderCapabilitySameEncoder = 1,
    WICBitmapDecoderCapabilityCanDecodeAllImages = 2,
    WICBitmapDecoderCapabilityCanDecodeSomeImages = 4,
    WICBitmapDecoderCapabilityCanEnumerateMetadata = 8,
    WICBitmapDecoderCapabilityCanDecodeThumbnail = 16,
}
