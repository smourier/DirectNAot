#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-imediaevent
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b6-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaEvent : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-geteventhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventHandle(out nint hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(out int lEventCode, out nint lParam1, out nint lParam2, int msTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-waitforcompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForCompletion(int msTimeout, out int pEvCode);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-canceldefaulthandling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelDefaultHandling(int lEvCode);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-restoredefaulthandling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreDefaultHandling(int lEvCode);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaevent-freeeventparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreeEventParams(int lEvCode, nint lParam1, nint lParam2);
}
