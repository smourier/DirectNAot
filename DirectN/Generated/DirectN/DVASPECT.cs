#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypes/ne-wtypes-dvaspect
public enum DVASPECT : uint
{
    DVASPECT_CONTENT = 1,
    DVASPECT_THUMBNAIL = 2,
    DVASPECT_ICON = 4,
    DVASPECT_DOCPRINT = 8,
    DVASPECT_OPAQUE = 16,
    DVASPECT_TRANSPARENT = 32,
}
