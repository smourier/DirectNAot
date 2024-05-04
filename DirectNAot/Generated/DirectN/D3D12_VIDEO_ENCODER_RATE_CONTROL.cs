#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_rate_control
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL
{
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE Mode;
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS ConfigParams;
    public DXGI_RATIONAL TargetFrameRate;
}
