#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nn-windows-ui-composition-interop-icompositorinterop
[GeneratedComInterface, Guid("25297d5c-3ad4-4c9c-b5cf-e36a38512330")]
public partial interface ICompositorInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositorinterop-createcompositionsurfaceforhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, out nint /* object */ result);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositorinterop-createcompositionsurfaceforswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompositionSurfaceForSwapChain(nint swapChain, out nint /* object */ result);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositorinterop-creategraphicsdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGraphicsDevice(nint renderingDevice, out nint /* object */ result);
}
