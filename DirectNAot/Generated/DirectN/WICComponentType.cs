namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wiccomponenttype
public enum WICComponentType
{
    WICDecoder = 1,
    WICEncoder = 2,
    WICPixelFormatConverter = 4,
    WICMetadataReader = 8,
    WICMetadataWriter = 16,
    WICPixelFormat = 32,
    WICAllComponents = 63,
}
