#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("aca16614-5d3d-11d2-960e-00c04f8ee628")]
public partial interface ISpNotifyTranslator : ISpNotifySink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitCallback(ref SPNOTIFYCALLBACK pfnCallback, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitSpNotifyCallback(ISpNotifyCallback pSpCallback, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitWin32Event(HANDLE hEvent, BOOL fCloseHandleOnRelease);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Wait(uint dwMilliseconds);
    
    [PreserveSig]
    HANDLE GetEventHandle();
}
