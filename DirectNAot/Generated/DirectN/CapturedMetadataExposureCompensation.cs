namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-capturedmetadataexposurecompensation
[StructLayout(LayoutKind.Sequential)]
public partial struct CapturedMetadataExposureCompensation
{
    public ulong Flags;
    public int Value;
}
