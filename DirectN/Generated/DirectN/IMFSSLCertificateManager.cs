#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsslcertificatemanager
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("61f7d887-1230-4a8b-aeba-8ad434d1a64d")]
public partial interface IMFSSLCertificateManager
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsslcertificatemanager-getclientcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientCertificate(PWSTR pszURL, out nint /* byte array */ ppbData, out uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsslcertificatemanager-begingetclientcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginGetClientCertificate(PWSTR pszURL, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsslcertificatemanager-endgetclientcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndGetClientCertificate(IMFAsyncResult pResult, out nint /* byte array */ ppbData, out uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsslcertificatemanager-getcertificatepolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificatePolicy(PWSTR pszURL, out BOOL pfOverrideAutomaticCheck, out BOOL pfClientCertificateAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsslcertificatemanager-onservercertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnServerCertificate(PWSTR pszURL, nint /* byte array */ pbData, uint cbData, out BOOL pfIsGood);
}
