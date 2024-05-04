namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nn-windows-ui-composition-interop-icompositiondrawingsurfaceinterop
[GeneratedComInterface, Guid("fd04e6e3-fe0c-4c3c-ab19-a07601a576ee")]
public partial interface ICompositionDrawingSurfaceInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDraw(nint /* optional RECT* */ updateRect, in Guid iid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ updateObject, out POINT updateOffset);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDraw();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-resize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resize(SIZE sizePixels);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-scroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Scroll(nint /* optional RECT* */ scrollRect, nint /* optional RECT* */ clipRect, int offsetX, int offsetY);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-resumedraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeDraw();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiondrawingsurfaceinterop-suspenddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuspendDraw();
}
