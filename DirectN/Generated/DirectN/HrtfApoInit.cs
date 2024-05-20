#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfapoinit
[StructLayout(LayoutKind.Sequential)]
public partial struct HrtfApoInit
{
    public nint distanceDecay;
    public nint directivity;
}
