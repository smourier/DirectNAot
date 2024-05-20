#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12protectedresourcesession1
[GeneratedComInterface, Guid("d6f12dd6-76fb-406e-8961-4296eefc0409")]
public partial interface ID3D12ProtectedResourceSession1 : ID3D12ProtectedResourceSession
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12protectedresourcesession1-getdesc1
    [PreserveSig]
    D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1();
}
