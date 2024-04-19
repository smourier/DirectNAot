namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_minimum_output_protection_levels
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_MINIMUM_OUTPUT_PROTECTION_LEVELS
{
    public ushort wCompressedDigitalVideo;
    public ushort wUncompressedDigitalVideo;
    public ushort wAnalogVideo;
    public ushort wCompressedDigitalAudio;
    public ushort wUncompressedDigitalAudio;
}
