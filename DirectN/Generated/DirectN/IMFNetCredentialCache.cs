#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetcredentialcache
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5b87ef6c-7ed8-434f-ba0e-184fac1628d1")]
public partial interface IMFNetCredentialCache
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialcache-getcredential
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredential(PWSTR pszUrl, PWSTR pszRealm, uint dwAuthenticationFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFNetCredential>))] out IMFNetCredential ppCred, out uint pdwRequirementsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialcache-setgood
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGood(IMFNetCredential pCred, BOOL fGood);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredentialcache-setuseroptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserOptions(IMFNetCredential pCred, uint dwOptionsFlags);
}
