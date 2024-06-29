#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftrustedinput
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("542612c4-a1b8-4632-b521-de11ea64a0b0")]
public partial interface IMFTrustedInput
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftrustedinput-getinputtrustauthority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputTrustAuthority(uint dwStreamID, in Guid riid, out nint ppunkObject);
}
