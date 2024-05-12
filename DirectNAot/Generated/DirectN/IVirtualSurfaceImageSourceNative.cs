#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative
[GeneratedComInterface, Guid("e9550983-360b-4f53-b391-afd695078691")]
public partial interface IVirtualSurfaceImageSourceNative : ISurfaceImageSourceNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-invalidate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invalidate(RECT updateRect);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-getupdaterectcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUpdateRectCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-getupdaterects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUpdateRects([In][Out][MarshalUsing(CountElementName = nameof(count))] RECT[] updates, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-getvisiblebounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisibleBounds(out RECT bounds);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-registerforupdatesneeded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForUpdatesNeeded(IVirtualSurfaceUpdatesCallbackNative? callback);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-ivirtualsurfaceimagesourcenative-resize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resize(int newWidth, int newHeight);
}
