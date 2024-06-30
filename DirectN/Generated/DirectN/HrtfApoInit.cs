#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfapoinit
public partial struct HrtfApoInit
{
    public nint distanceDecay;
    public nint directivity;
}
