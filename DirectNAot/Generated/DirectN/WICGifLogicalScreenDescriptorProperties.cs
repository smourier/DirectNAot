#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicgiflogicalscreendescriptorproperties
public enum WICGifLogicalScreenDescriptorProperties
{
    WICGifLogicalScreenSignature = 1,
    WICGifLogicalScreenDescriptorWidth = 2,
    WICGifLogicalScreenDescriptorHeight = 3,
    WICGifLogicalScreenDescriptorGlobalColorTableFlag = 4,
    WICGifLogicalScreenDescriptorColorResolution = 5,
    WICGifLogicalScreenDescriptorSortFlag = 6,
    WICGifLogicalScreenDescriptorGlobalColorTableSize = 7,
    WICGifLogicalScreenDescriptorBackgroundColorIndex = 8,
    WICGifLogicalScreenDescriptorPixelAspectRatio = 9,
}
