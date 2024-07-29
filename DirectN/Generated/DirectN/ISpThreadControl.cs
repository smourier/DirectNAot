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
    HRESULT WaitForThreadDone(BOOL fForceStop, out HRESULT phrThreadResult, uint msTimeOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateThread();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE ThreadHandle();
    
    [PreserveSig]
    uint ThreadId();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE NotifyEvent();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HWND WindowHandle();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE ThreadCompleteEvent();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE ExitThreadEvent();
}
