#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfdirectivitycardioid
[StructLayout(LayoutKind.Sequential)]
public partial struct HrtfDirectivityCardioid
{
    public HrtfDirectivity directivity;
    public float order;
}
