namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d
[GeneratedComInterface, Guid("54298223-41e1-4a41-9c08-02e8256864a1")]
public partial interface ISurfaceImageSourceNativeWithD2D
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d-setdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDevice(nint device);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDraw(FoundationRECT updateRect, in Guid iid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ updateObject, out FoundationPOINT offset);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDraw();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d-suspenddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuspendDraw();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-isurfaceimagesourcenativewithd2d-resumedraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeDraw();
}
