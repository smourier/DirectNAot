#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenative
[GeneratedComInterface, Guid("f2e9edc1-d307-4525-9886-0fafaa44163c")]
public partial interface ISurfaceImageSourceNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenative-setdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDevice(IDXGIDevice device);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenative-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDraw(RECT updateRect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISurface>))] out IDXGISurface surface, out POINT offset);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenative-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDraw();
}
