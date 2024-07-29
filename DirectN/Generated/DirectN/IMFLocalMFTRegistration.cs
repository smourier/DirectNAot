#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imflocalmftregistration
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("149c4d73-b4be-4f8d-8b87-079e926b6add")]
public partial interface IMFLocalMFTRegistration
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imflocalmftregistration-registermfts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterMFTs([In][MarshalUsing(CountElementName = nameof(cMFTs))] MFT_REGISTRATION_INFO[] pMFTs, uint cMFTs);
}
