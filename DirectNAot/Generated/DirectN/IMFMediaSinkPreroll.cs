#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasinkpreroll
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5dfd4b2a-7674-4110-a4e6-8a68fd5f3688")]
public partial interface IMFMediaSinkPreroll
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasinkpreroll-notifypreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyPreroll(long hnsUpcomingStartTime);
}
