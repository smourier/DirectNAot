namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsecurechannel
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d0ae555d-3b12-4d97-b060-0990bc5aeb67")]
public partial interface IMFSecureChannel
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsecurechannel-getcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificate(out nint /* byte array */ ppCert, out uint pcbCert);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsecurechannel-setupsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetupSession(nint /* byte array */ pbEncryptedSessionKey, uint cbSessionKey);
}
