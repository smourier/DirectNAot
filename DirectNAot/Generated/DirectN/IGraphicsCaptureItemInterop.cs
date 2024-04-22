namespace DirectN;

[GeneratedComInterface, Guid("3628e81b-3cac-4c60-b7f4-23ce0e0c3356")]
public partial interface IGraphicsCaptureItemInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.capture.interop/nf-windows-graphics-capture-interop-igraphicscaptureiteminterop-createforwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateForWindow(HWND window, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ result);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.capture.interop/nf-windows-graphics-capture-interop-igraphicscaptureiteminterop-createformonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateForMonitor(HMONITOR monitor, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ result);
}
