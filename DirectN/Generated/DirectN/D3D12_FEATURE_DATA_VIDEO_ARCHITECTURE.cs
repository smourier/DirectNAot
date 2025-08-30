#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE : IValueGet<BOOL>
{
    public BOOL IOCoherent;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => IOCoherent;
    readonly object? IValueGet.GetValue() => IOCoherent;
}
