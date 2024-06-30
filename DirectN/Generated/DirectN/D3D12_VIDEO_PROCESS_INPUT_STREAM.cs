#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_input_stream
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM
{
    public nint pTexture2D;
    public uint Subresource;
    public D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet;
}
