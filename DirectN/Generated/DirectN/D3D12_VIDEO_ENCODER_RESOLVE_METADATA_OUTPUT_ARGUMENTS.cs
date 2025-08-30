#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_resolve_metadata_output_arguments
public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS : IValueGet<D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER>
{
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER ResolvedLayoutMetadata;
    
    readonly D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER IValueGet<D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER>.GetValue() => ResolvedLayoutMetadata;
    readonly object? IValueGet.GetValue() => ResolvedLayoutMetadata;
}
