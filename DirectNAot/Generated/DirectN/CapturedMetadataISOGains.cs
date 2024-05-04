#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-capturedmetadataisogains
[StructLayout(LayoutKind.Sequential)]
public partial struct CapturedMetadataISOGains
{
    public float AnalogGain;
    public float DigitalGain;
}
