#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftrackedsample
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("245bf8e9-0755-40f7-88a5-ae0f18d55e17")]
public partial interface IMFTrackedSample
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftrackedsample-setallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocator(IMFAsyncCallback pSampleAllocator, nint pUnkState);
}
