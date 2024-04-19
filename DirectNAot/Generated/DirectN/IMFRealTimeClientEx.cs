namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfrealtimeclientex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("03910848-ab16-4611-b100-17b88ae2f248")]
public partial interface IMFRealTimeClientEx
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclientex-registerthreadsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterThreadsEx(ref uint pdwTaskIndex, PWSTR wszClassName, int lBasePriority);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclientex-unregisterthreads
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterThreads();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclientex-setworkqueueex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkQueueEx(uint dwMultithreadedWorkQueueId, int lWorkItemBasePriority);
}
