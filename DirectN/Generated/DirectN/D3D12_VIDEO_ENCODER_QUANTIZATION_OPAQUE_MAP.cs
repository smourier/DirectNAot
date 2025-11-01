#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP : IValueGet<nint>
{
    public nint pOpaqueQuantizationMap;
    
    readonly nint IValueGet<nint>.GetValue() => pOpaqueQuantizationMap;
    readonly object? IValueGet.GetValue() => pOpaqueQuantizationMap;
}
