namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-ivideowindow
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b4-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IVideoWindow : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_caption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Caption(BSTR strCaption);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_caption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Caption(out BSTR strCaption);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_windowstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WindowStyle(int WindowStyle);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_windowstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowStyle(out int WindowStyle);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_windowstyleex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WindowStyleEx(int WindowStyleEx);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_windowstyleex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowStyleEx(out int WindowStyleEx);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_autoshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AutoShow(int AutoShow);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_autoshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AutoShow(out int AutoShow);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_windowstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WindowState(int WindowState);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_windowstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowState(out SHOW_WINDOW_CMD WindowState);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_backgroundpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BackgroundPalette(int BackgroundPalette);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_backgroundpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BackgroundPalette(out int pBackgroundPalette);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_visible
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Visible(int Visible);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_visible
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Visible(out int pVisible);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_left
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Left(int Left);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_left
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Left(out int pLeft);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_width
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Width(int Width);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_width
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Width(out int pWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_top
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Top(int Top);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_top
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Top(out int pTop);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_height
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Height(int Height);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_height
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Height(out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_owner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Owner(nint Owner);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_owner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Owner(out nint Owner);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_messagedrain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MessageDrain(nint Drain);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_messagedrain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MessageDrain(out nint Drain);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_bordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BorderColor(out int Color);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_bordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BorderColor(int Color);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-get_fullscreenmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FullScreenMode(out int FullScreenMode);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-put_fullscreenmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FullScreenMode(int FullScreenMode);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-setwindowforeground
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWindowForeground(int Focus);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-notifyownermessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyOwnerMessage(nint hwnd, int uMsg, nint wParam, nint lParam);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-setwindowposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWindowPosition(int Left, int Top, int Width, int Height);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-getwindowposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowPosition(out int pLeft, out int pTop, out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-getminidealimagesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinIdealImageSize(out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-getmaxidealimagesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxIdealImageSize(out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-getrestoreposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRestorePosition(out int pLeft, out int pTop, out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-hidecursor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HideCursor(OA_BOOL HideCursor);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ivideowindow-iscursorhidden
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCursorHidden(out int CursorHidden);
}
