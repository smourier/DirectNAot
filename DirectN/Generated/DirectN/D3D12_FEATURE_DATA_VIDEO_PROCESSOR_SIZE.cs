#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_processor_size
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE
{
    public uint NodeMask;
    public nint pOutputStreamDesc;
    public uint NumInputStreamDescs;
    public nint pInputStreamDescs;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
