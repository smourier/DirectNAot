namespace DirectN;

[GeneratedComInterface, Guid("2baeef81-2ca3-4331-98f3-26ec5abefb03")]
public partial interface ISpTaskManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThreadPoolInfo(in SPTMTHREADINFO pPoolInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThreadPoolInfo(out SPTMTHREADINFO pPoolInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueTask(ISpTask pTask, nint pvTaskData, HANDLE hCompEvent, ref uint pdwGroupId, out uint pTaskID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReoccurringTask(ISpTask pTask, nint pvTaskData, HANDLE hCompEvent, out ISpNotifySink ppTaskCtrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateThreadControl(ISpThreadTask pTask, nint pvTaskData, int nPriority, out ISpThreadControl ppTaskCtrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateTask(uint dwTaskId, uint ulWaitPeriod);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateTaskGroup(uint dwGroupId, uint ulWaitPeriod);
}
