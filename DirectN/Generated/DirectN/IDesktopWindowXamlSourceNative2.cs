#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.desktopwindowxamlsource/nn-windows-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative2
[GeneratedComInterface, Guid("e3dcd8c7-3057-4692-99c3-7b7720afda31")]
public partial interface IDesktopWindowXamlSourceNative2 : IDesktopWindowXamlSourceNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.desktopwindowxamlsource/nf-windows-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative2-pretranslatemessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreTranslateMessage(in MSG message, ref BOOL result);
}
