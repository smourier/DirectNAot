namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/nn-dxgi1_6-idxgifactory7
[SupportedOSPlatform("windows10.0.17763")]
[GeneratedComInterface, Guid("a4966eed-76db-44da-84c1-ee9a7afb20a8")]
public partial interface IDXGIFactory7 : IDXGIFactory6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAdaptersChangedEvent(HANDLE hEvent, out uint pdwCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterAdaptersChangedEvent(uint dwCookie);
}
