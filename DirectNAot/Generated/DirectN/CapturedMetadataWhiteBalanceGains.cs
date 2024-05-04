#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-capturedmetadatawhitebalancegains
[StructLayout(LayoutKind.Sequential)]
public partial struct CapturedMetadataWhiteBalanceGains
{
    public float R;
    public float G;
    public float B;
}
