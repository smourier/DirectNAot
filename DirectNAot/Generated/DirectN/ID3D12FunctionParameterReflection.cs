namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12functionparameterreflection
[GeneratedComInterface, Guid("ec25f42d-7006-4f2b-b33e-02cc3375733f")]
public partial interface ID3D12FunctionParameterReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12functionparameterreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out D3D12_PARAMETER_DESC pDesc);
}
