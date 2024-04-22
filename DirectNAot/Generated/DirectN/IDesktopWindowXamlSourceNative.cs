namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.desktopwindowxamlsource/nn-windows-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative
[GeneratedComInterface, Guid("3cbcf1bf-2f76-4e9c-96ab-e84b37972554")]
public partial interface IDesktopWindowXamlSourceNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.desktopwindowxamlsource/nf-windows-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative-attachtowindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachToWindow(HWND parentWnd);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.desktopwindowxamlsource/nf-windows-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative-get_windowhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowHandle(out HWND hWnd);
}
