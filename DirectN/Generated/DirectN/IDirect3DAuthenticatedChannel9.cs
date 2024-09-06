#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dauthenticatedchannel9
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ff24beee-da21-4beb-98b5-d2f899f98af9")]
public partial interface IDirect3DAuthenticatedChannel9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dauthenticatedchannel9-getcertificatesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateSize(ref uint pCertificateSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dauthenticatedchannel9-getcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificate(uint CertifacteSize, nint /* byte array */ ppCertificate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dauthenticatedchannel9-negotiatekeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateKeyExchange(uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dauthenticatedchannel9-query
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Query(uint InputSize, nint pInput, uint OutputSize, nint pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dauthenticatedchannel9-configure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Configure(uint InputSize, nint pInput, ref D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT pOutput);
}
