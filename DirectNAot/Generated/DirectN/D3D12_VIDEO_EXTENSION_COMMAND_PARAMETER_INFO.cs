namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_extension_command_parameter_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO
{
    public PWSTR Name;
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE Type;
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS Flags;
}
