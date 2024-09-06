#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iolewindow
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000114-0000-0000-c000-000000000046")]
public partial interface IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolewindow-getwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(out HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolewindow-contextsensitivehelp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContextSensitiveHelp(BOOL fEnterMode);
}
