#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT_OUTPUT_ARGUMENTS : IValueGet<nint>
{
    public nint pOpaqueLayoutBuffer;
    
    readonly nint IValueGet<nint>.GetValue() => pOpaqueLayoutBuffer;
    readonly object? IValueGet.GetValue() => pOpaqueLayoutBuffer;
}
