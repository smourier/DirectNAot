#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5eff4aef-8487-11d2-961c-00c04f8ee628")]
public partial interface ISpNotifySource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifySink(ISpNotifySink? pNotifySink);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyCallbackFunction(ref SPNOTIFYCALLBACK pfnCallback, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyCallbackInterface(ISpNotifyCallback pSpCallback, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyWin32Event();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForNotifyEvent(uint dwMilliseconds);
    
    [PreserveSig]
    HANDLE GetNotifyEventHandle();
}
