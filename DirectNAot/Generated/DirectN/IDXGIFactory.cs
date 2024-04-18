namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgifactory
[GeneratedComInterface, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public partial interface IDXGIFactory : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-enumadapters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAdapters(uint Adapter, out IDXGIAdapter ppAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-makewindowassociation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-getwindowassociation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWindowAssociation(out HWND pWindowHandle);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-createswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSwapChain(nint pDevice, in DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-createsoftwareadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSoftwareAdapter(HMODULE Module, out IDXGIAdapter ppAdapter);
}
