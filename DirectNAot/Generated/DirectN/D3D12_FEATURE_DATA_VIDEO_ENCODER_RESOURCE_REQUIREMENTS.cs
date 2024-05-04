#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_resource_requirements
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsSupported;
    public uint CompressedBitstreamBufferAccessAlignment;
    public uint EncoderMetadataBufferAccessAlignment;
    public uint MaxEncoderOutputMetadataBufferSize;
}
