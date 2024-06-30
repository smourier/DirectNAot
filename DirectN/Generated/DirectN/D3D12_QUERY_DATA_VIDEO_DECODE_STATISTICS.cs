#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_query_data_video_decode_statistics
public partial struct D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS
{
    public ulong Status;
    public ulong NumMacroblocksAffected;
    public DXGI_RATIONAL FrameRate;
    public uint BitRate;
}
