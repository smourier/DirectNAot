#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mf_camera_control_range_info
[StructLayout(LayoutKind.Sequential)]
public partial struct MF_CAMERA_CONTROL_RANGE_INFO
{
    public int minValue;
    public int maxValue;
    public int stepValue;
    public int defaultValue;
}
