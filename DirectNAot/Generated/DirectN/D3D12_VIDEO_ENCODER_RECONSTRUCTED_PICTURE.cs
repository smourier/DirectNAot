#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_reconstructed_picture
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE
{
    public nint pReconstructedPicture;
    public uint ReconstructedPictureSubresource;
}
