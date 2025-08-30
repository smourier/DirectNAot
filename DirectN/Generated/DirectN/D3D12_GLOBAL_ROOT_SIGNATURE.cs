#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_global_root_signature
public partial struct D3D12_GLOBAL_ROOT_SIGNATURE : IValueGet<nint>
{
    public nint pGlobalRootSignature;
    
    readonly nint IValueGet<nint>.GetValue() => pGlobalRootSignature;
    readonly object? IValueGet.GetValue() => pGlobalRootSignature;
}
