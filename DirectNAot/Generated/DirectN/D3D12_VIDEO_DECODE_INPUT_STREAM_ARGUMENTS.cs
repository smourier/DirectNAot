#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_input_stream_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
{
    public uint NumFrameArguments;
    public InlineArrayD3D12_VIDEO_DECODE_FRAME_ARGUMENT_10 FrameArguments;
    public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;
    public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;
    public nint pHeap;
}
