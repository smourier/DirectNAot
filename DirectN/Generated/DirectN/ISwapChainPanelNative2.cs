#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainpanelnative2
[GeneratedComInterface, Guid("d5a2f60c-37b2-44a2-937b-8d8eb9726821")]
public partial interface ISwapChainPanelNative2 : ISwapChainPanelNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSwapChainHandle(HANDLE swapChainHandle);
}
