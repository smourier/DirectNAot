#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftimer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e56e4cbd-8f70-49d8-a0f8-edb3d6ab9bf2")]
public partial interface IMFTimer
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimer-settimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimer(uint dwFlags, long llClockTime, IMFAsyncCallback pCallback, nint punkState, out nint ppunkKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftimer-canceltimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelTimer(nint punkKey);
}
