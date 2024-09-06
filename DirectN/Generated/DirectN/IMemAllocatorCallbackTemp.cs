#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imemallocatorcallbacktemp
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("379a0cf0-c1de-11d2-abf5-00a0c905f375")]
public partial interface IMemAllocatorCallbackTemp : IMemAllocator
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocatorcallbacktemp-setnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotify(IMemAllocatorNotifyCallbackTemp pNotify);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocatorcallbacktemp-getfreecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFreeCount(out int plBuffersFree);
}
