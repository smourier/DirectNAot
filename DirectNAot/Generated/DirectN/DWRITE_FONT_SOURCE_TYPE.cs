#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ne-dwrite_3-dwrite_font_source_type
public enum DWRITE_FONT_SOURCE_TYPE
{
    DWRITE_FONT_SOURCE_TYPE_UNKNOWN = 0,
    DWRITE_FONT_SOURCE_TYPE_PER_MACHINE = 1,
    DWRITE_FONT_SOURCE_TYPE_PER_USER = 2,
    DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE = 3,
    DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER = 4,
}
