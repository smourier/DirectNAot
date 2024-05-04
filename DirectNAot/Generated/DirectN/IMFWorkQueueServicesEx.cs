#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfworkqueueservicesex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("96bf961b-40fe-42f1-ba9d-320238b49700")]
public partial interface IMFWorkQueueServicesEx : IMFWorkQueueServices
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservicesex-gettopologyworkqueuemmcsspriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopologyWorkQueueMMCSSPriority(uint dwTopologyWorkQueueId, out int plPriority);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservicesex-beginregisterplatformworkqueuewithmmcssex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx(uint dwPlatformWorkQueue, PWSTR wszClass, uint dwTaskId, int lPriority, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservicesex-getplatformworkqueuemmcsspriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlatformWorkQueueMMCSSPriority(uint dwPlatformWorkQueueId, out int plPriority);
}
