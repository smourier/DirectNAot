namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsampleprotection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8e36395f-c7b9-43c4-a54d-512b4af63c95")]
public partial interface IMFSampleProtection
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleprotection-getinputprotectionversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputProtectionVersion(out uint pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleprotection-getoutputprotectionversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputProtectionVersion(out uint pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleprotection-getprotectioncertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectionCertificate(uint dwVersion, out nint /* byte array */ ppCert, out uint pcbCert);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleprotection-initoutputprotection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitOutputProtection(uint dwVersion, uint dwOutputId, nint /* byte array */ pbCert, uint cbCert, out nint /* byte array */ ppbSeed, out uint pcbSeed);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleprotection-initinputprotection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitInputProtection(uint dwVersion, uint dwInputId, nint /* byte array */ pbSeed, uint cbSeed);
}
