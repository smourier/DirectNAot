#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12functionparameterreflection
public partial struct ID3D12FunctionParameterReflection
{
    public static readonly ID3D12FunctionParameterReflection Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D12_PARAMETER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D12FunctionParameterReflection*,D3D12_PARAMETER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D12FunctionParameterReflection*)VTablePtr, (D3D12_PARAMETER_DESC*)Unsafe.AsPointer(ref pDesc));
}
