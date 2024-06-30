#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11functionparameterreflection
public partial struct ID3D11FunctionParameterReflection
{
    public static readonly ID3D11FunctionParameterReflection Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionparameterreflection-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D11_PARAMETER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D11FunctionParameterReflection*,D3D11_PARAMETER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ID3D11FunctionParameterReflection*)VTablePtr, (D3D11_PARAMETER_DESC*)Unsafe.AsPointer(ref pDesc));
}
