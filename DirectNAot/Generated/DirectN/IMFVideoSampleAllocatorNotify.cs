namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideosampleallocatornotify
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a792cdbe-c374-4e89-8335-278e7b9956a4")]
public partial interface IMFVideoSampleAllocatorNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideosampleallocatornotify-notifyrelease
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyRelease();
}
