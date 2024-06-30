#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_extension_command_count
public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT
{
    public uint NodeIndex;
    public uint CommandCount;
}
