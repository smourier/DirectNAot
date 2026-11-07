#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_USER_DEFINED_ANNOTATION : IValueGet<BOOL>
{
    public BOOL Supported;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => Supported;
    readonly object? IValueGet.GetValue() => Supported;
}
