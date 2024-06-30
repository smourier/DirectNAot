#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_extension_command_parameters
public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS
{
    public Guid CommandId;
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;
    public uint ParameterCount;
    public nint pParameterInfos;
}
