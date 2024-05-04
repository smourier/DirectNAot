#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamvfwcapturedialogs
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d8d715a0-6e5e-11d0-b3f0-00aa003761c5")]
public partial interface IAMVfwCaptureDialogs
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcapturedialogs-hasdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasDialog(int iDialog);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcapturedialogs-showdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowDialog(int iDialog, HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcapturedialogs-senddrivermessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendDriverMessage(int iDialog, int uMsg, int dw1, int dw2);
}
