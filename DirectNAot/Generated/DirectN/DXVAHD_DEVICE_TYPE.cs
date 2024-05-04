#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_device_type
public enum DXVAHD_DEVICE_TYPE
{
    DXVAHD_DEVICE_TYPE_HARDWARE = 0,
    DXVAHD_DEVICE_TYPE_SOFTWARE = 1,
    DXVAHD_DEVICE_TYPE_REFERENCE = 2,
    DXVAHD_DEVICE_TYPE_OTHER = 3,
}
