#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainbackgroundpanelnative
[GeneratedComInterface, Guid("43bebd4e-add5-4035-8f85-5608d08e9dc9")]
public partial interface ISwapChainBackgroundPanelNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSwapChain(IDXGISwapChain swapChain);
}
