namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11cryptosession
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720")]
public partial interface ID3D11CryptoSession : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11cryptosession-getcryptotype
    [PreserveSig]
    void GetCryptoType(out Guid pCryptoType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11cryptosession-getdecoderprofile
    [PreserveSig]
    void GetDecoderProfile(out Guid pDecoderProfile);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11cryptosession-getcertificatesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateSize(out uint pCertificateSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11cryptosession-getcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificate(uint CertificateSize, nint /* byte array */ pCertificate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11cryptosession-getcryptosessionhandle
    [PreserveSig]
    void GetCryptoSessionHandle(out HANDLE pCryptoSessionHandle);
}
