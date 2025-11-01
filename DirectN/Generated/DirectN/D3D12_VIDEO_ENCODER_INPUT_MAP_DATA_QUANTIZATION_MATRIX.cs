#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX : IValueGet<nint>
{
    public nint pQuantizationMap;
    
    readonly nint IValueGet<nint>.GetValue() => pQuantizationMap;
    readonly object? IValueGet.GetValue() => pQuantizationMap;
}
