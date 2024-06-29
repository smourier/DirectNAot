#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12functionparameterreflection
public partial struct ID3D12FunctionParameterReflection
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D12_PARAMETER_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12FunctionParameterReflection*,D3D12_PARAMETER_DESC*, HRESULT>)(((void**)VTablePtr)[0]))((ID3D12FunctionParameterReflection*)VTablePtr, (D3D12_PARAMETER_DESC*)Unsafe.AsPointer(ref pDesc));
    }
}
