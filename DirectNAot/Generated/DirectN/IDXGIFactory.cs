namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgifactory
[GeneratedComInterface, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public partial interface IDXGIFactory : IDXGIObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapters(uint Adapter, out IDXGIAdapter ppAdapter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowAssociation(out HWND pWindowHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChain(nint pDevice, in DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSoftwareAdapter(HMODULE Module, out IDXGIAdapter ppAdapter);
}
