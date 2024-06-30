#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_extension_command_support
public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT
{
    public uint NodeIndex;
    public Guid CommandId;
    public nint pInputData;
    public nuint InputDataSizeInBytes;
    public nint pOutputData;
    public nuint OutputDataSizeInBytes;
}
