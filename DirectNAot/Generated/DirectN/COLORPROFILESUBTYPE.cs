namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ne-icm-colorprofilesubtype
public enum COLORPROFILESUBTYPE
{
    CPST_PERCEPTUAL = 0,
    CPST_RELATIVE_COLORIMETRIC = 1,
    CPST_SATURATION = 2,
    CPST_ABSOLUTE_COLORIMETRIC = 3,
    CPST_NONE = 4,
    CPST_RGB_WORKING_SPACE = 5,
    CPST_CUSTOM_WORKING_SPACE = 6,
    CPST_STANDARD_DISPLAY_COLOR_MODE = 7,
    CPST_EXTENDED_DISPLAY_COLOR_MODE = 8,
}
