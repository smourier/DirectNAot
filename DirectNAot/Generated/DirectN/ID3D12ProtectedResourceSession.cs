namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12protectedresourcesession
[GeneratedComInterface, Guid("6cd696f4-f289-40cc-8091-5a6c0a099c3d")]
public partial interface ID3D12ProtectedResourceSession : ID3D12ProtectedSession
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12protectedresourcesession-getdesc
    [PreserveSig]
    D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc();
}
