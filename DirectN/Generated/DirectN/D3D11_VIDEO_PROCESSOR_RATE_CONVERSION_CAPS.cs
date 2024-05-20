#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_rate_conversion_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS
{
    public uint PastFrames;
    public uint FutureFrames;
    public uint ProcessorCaps;
    public uint ITelecineCaps;
    public uint CustomRateCount;
}
