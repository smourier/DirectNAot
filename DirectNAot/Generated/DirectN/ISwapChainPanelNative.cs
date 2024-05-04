#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainpanelnative
[GeneratedComInterface, Guid("f92f19d2-3ade-45a6-a20c-f6f1ea90554b")]
public partial interface ISwapChainPanelNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSwapChain(IDXGISwapChain swapChain);
}
