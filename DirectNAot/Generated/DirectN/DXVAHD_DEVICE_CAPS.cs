namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_device_caps
public enum DXVAHD_DEVICE_CAPS
{
    DXVAHD_DEVICE_CAPS_LINEAR_SPACE = 1,
    DXVAHD_DEVICE_CAPS_xvYCC = 2,
    DXVAHD_DEVICE_CAPS_RGB_RANGE_CONVERSION = 4,
    DXVAHD_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION = 8,
}
