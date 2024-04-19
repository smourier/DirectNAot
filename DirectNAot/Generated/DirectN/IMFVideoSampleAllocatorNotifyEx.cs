namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideosampleallocatornotifyex
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("3978aa1a-6d5b-4b7f-a340-90899189ae34")]
public partial interface IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocatornotifyex-notifyprune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyPrune(IMFSample __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
}
