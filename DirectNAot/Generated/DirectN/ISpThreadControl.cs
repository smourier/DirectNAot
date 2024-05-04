#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a6be4d73-4403-4358-b22d-0346e23b1764")]
public partial interface ISpThreadControl : ISpNotifySink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartThread(uint dwFlags, out HWND phwnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForThreadDone([MarshalAs(UnmanagedType.U4)] bool fForceStop, out HRESULT phrThreadResult, uint msTimeOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateThread();
    
    [PreserveSig]
    HANDLE ThreadHandle();
    
    [PreserveSig]
    uint ThreadId();
    
    [PreserveSig]
    HANDLE NotifyEvent();
    
    [PreserveSig]
    HWND WindowHandle();
    
    [PreserveSig]
    HANDLE ThreadCompleteEvent();
    
    [PreserveSig]
    HANDLE ExitThreadEvent();
}
