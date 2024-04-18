namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1hwndrendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd90698-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1HwndRenderTarget : ID2D1RenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1hwndrendertarget-checkwindowstate
    [PreserveSig]
    public D2D1_WINDOW_STATE CheckWindowState();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1hwndrendertarget-resize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Resize(in D2D_SIZE_U pixelSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1hwndrendertarget-gethwnd
    [PreserveSig]
    public HWND GetHwnd();
}
