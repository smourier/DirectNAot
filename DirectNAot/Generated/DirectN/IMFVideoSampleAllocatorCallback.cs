namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideosampleallocatorcallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("992388b4-3372-4f67-8b6f-c84c071f4751")]
public partial interface IMFVideoSampleAllocatorCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocatorcallback-setcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCallback(IMFVideoSampleAllocatorNotify pNotify);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocatorcallback-getfreesamplecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFreeSampleCount(out int plSamples);
}
