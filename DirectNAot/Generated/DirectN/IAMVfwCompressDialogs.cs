#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamvfwcompressdialogs
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d8d715a3-6e5e-11d0-b3f0-00aa003761c5")]
public partial interface IAMVfwCompressDialogs
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcompressdialogs-showdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowDialog(int iDialog, HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcompressdialogs-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(nint pState, ref int pcbState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcompressdialogs-setstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(nint pState, int cbState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvfwcompressdialogs-senddrivermessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendDriverMessage(int uMsg, int dw1, int dw2);
}
