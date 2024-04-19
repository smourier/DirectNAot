namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsecure/nn-wmsecure-iwmauthorizer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d9b67d36-a9ad-4eb4-baef-db284ef5504c")]
public partial interface IWMAuthorizer
{
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmauthorizer-getcertcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertCount(out uint pcCerts);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmauthorizer-getcert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCert(uint dwIndex, out nint /* byte array */ ppbCertData);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmauthorizer-getshareddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedData(uint dwCertIndex, nint /* byte array */ pbSharedData, nint /* byte array */ pbCert, out nint /* byte array */ ppbSharedData);
}
