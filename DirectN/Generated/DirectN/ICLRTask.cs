#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("28e66a4a-9906-4225-b231-9187c3eb8611")]
public partial interface ICLRTask
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SwitchIn(HANDLE threadHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SwitchOut();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMemStats(out COR_GC_THREAD_STATS memUsage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(BOOL fFull);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExitTask();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abort();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RudeAbort();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NeedsPriorityScheduling(out BOOL pbNeedsPriorityScheduling);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT YieldTask();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LocksHeld(out nuint pLockCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTaskIdentifier(ulong asked);
}
