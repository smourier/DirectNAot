#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imffieldofusemftunlock
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("508e71d3-ec66-4fc3-8775-b4b9ed6ba847")]
public partial interface IMFFieldOfUseMFTUnlock
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imffieldofusemftunlock-unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock(nint pUnkMFT);
}
