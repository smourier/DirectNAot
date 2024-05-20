#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wiccolorcontexttype
public enum WICColorContextType
{
    WICColorContextUninitialized = 0,
    WICColorContextProfile = 1,
    WICColorContextExifColorSpace = 2,
}
