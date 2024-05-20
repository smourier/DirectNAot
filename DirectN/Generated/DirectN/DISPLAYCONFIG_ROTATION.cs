#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ne-wingdi-displayconfig_rotation
public enum DISPLAYCONFIG_ROTATION
{
    DISPLAYCONFIG_ROTATION_IDENTITY = 1,
    DISPLAYCONFIG_ROTATION_ROTATE90 = 2,
    DISPLAYCONFIG_ROTATION_ROTATE180 = 3,
    DISPLAYCONFIG_ROTATION_ROTATE270 = 4,
}
