#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11functionparameterreflection
[GeneratedComInterface, Guid("42757488-334f-47fe-982e-1a65d08cc462")]
public partial interface ID3D11FunctionParameterReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionparameterreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D11_PARAMETER_DESC pDesc);
}
