#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtforientation
[StructLayout(LayoutKind.Sequential)]
public partial struct HrtfOrientation
{
    public InlineArraySingle9 element;
}
