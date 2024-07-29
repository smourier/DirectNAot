#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfrealtimeclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2347d60b-3fb5-480c-8803-8df3adcd3ef0")]
public partial interface IMFRealTimeClient
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclient-registerthreads
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterThreads(uint dwTaskIndex, PWSTR wszClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclient-unregisterthreads
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterThreads();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrealtimeclient-setworkqueue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkQueue(uint dwWorkQueueId);
}
