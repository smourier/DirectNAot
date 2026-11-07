#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_EXPLICIT_PSDBS : IValueGet<BOOL>
{
    public BOOL ExplicitPsdbsSupported;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => ExplicitPsdbsSupported;
    readonly object? IValueGet.GetValue() => ExplicitPsdbsSupported;
}
