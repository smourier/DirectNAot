#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11devicecontext3
[GeneratedComInterface, Guid("b4e3c01d-e79e-4637-91b2-510e9f4c9b8f")]
public partial interface ID3D11DeviceContext3 : ID3D11DeviceContext2
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11devicecontext3-flush1
    [PreserveSig]
    void Flush1(D3D11_CONTEXT_TYPE ContextType, HANDLE hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11devicecontext3-sethardwareprotectionstate
    [PreserveSig]
    void SetHardwareProtectionState(BOOL HwProtectionEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11devicecontext3-gethardwareprotectionstate
    [PreserveSig]
    void GetHardwareProtectionState(out BOOL pHwProtectionEnable);
}
