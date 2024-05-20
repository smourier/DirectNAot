#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_output_stream_arguments1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
{
    public nint pOutputTexture2D;
    public uint OutputSubresource;
    public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;
    public InlineArrayD3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM_4 Histograms;
}
