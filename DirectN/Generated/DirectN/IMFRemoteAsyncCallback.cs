#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfremoteasynccallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a27003d0-2354-4f2a-8d6a-ab7cff15437e")]
public partial interface IMFRemoteAsyncCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfremoteasynccallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke(HRESULT hr, nint pRemoteResult);
}
