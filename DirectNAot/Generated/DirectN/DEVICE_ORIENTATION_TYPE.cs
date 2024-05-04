#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ne-audioengineextensionapo-device_orientation_type
public enum DEVICE_ORIENTATION_TYPE
{
    DEVICE_NOT_ROTATED = 0,
    DEVICE_ROTATED_90_DEGREES_CLOCKWISE = 1,
    DEVICE_ROTATED_180_DEGREES_CLOCKWISE = 2,
    DEVICE_ROTATED_270_DEGREES_CLOCKWISE = 3,
}
