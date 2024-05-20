#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_output_resolution
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public uint ResolutionRatiosCount;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsSupported;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MinResolutionSupported;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MaxResolutionSupported;
    public uint ResolutionWidthMultipleRequirement;
    public uint ResolutionHeightMultipleRequirement;
    public nint pResolutionRatios;
}
