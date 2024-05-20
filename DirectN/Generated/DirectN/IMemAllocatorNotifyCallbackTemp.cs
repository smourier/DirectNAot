#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imemallocatornotifycallbacktemp
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("92980b30-c1de-11d2-abf5-00a0c905f375")]
public partial interface IMemAllocatorNotifyCallbackTemp
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocatornotifycallbacktemp-notifyrelease
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyRelease();
}
