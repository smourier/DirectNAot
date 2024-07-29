#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfqualityadvise2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f3706f0d-8ea2-4886-8000-7155e9ec2eae")]
public partial interface IMFQualityAdvise2 : IMFQualityAdvise
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadvise2-notifyqualityevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyQualityEvent(IMFMediaEvent pEvent, out uint pdwFlags);
}
