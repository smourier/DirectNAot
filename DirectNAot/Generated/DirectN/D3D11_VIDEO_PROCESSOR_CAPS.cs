#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_CAPS
{
    public uint DeviceCaps;
    public uint FeatureCaps;
    public uint FilterCaps;
    public uint InputFormatCaps;
    public uint AutoStreamCaps;
    public uint StereoCaps;
    public uint RateConversionCapsCount;
    public uint MaxInputStreams;
    public uint MaxStreamStates;
}
