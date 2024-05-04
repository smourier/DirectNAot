#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpresentationtimesource
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7ff12cce-f76f-41c2-863b-1666c8e5e139")]
public partial interface IMFPresentationTimeSource : IMFClock
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationtimesource-getunderlyingclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnderlyingClock(out IMFClock ppClock);
}
