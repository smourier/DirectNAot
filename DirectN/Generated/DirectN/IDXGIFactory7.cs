#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/nn-dxgi1_6-idxgifactory7
[SupportedOSPlatform("windows10.0.17763")]
[GeneratedComInterface, Guid("a4966eed-76db-44da-84c1-ee9a7afb20a8")]
public partial interface IDXGIFactory7 : IDXGIFactory6
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgifactory7-registeradapterschangedevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAdaptersChangedEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgifactory7-unregisteradapterschangedevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterAdaptersChangedEvent(uint dwCookie);
}
