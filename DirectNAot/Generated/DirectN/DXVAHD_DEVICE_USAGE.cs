#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_device_usage
public enum DXVAHD_DEVICE_USAGE
{
    DXVAHD_DEVICE_USAGE_PLAYBACK_NORMAL = 0,
    DXVAHD_DEVICE_USAGE_OPTIMAL_SPEED = 1,
    DXVAHD_DEVICE_USAGE_OPTIMAL_QUALITY = 2,
}
