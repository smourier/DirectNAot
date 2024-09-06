#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmcredentialcallback
[GeneratedComInterface, Guid("342e0eb7-e651-450c-975b-2ace2c90c48e")]
public partial interface IWMCredentialCallback
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcredentialcallback-acquirecredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireCredentials(PWSTR pwszRealm, PWSTR pwszSite, [MarshalUsing(CountElementName = nameof(cchUser))] PWSTR pwszUser, uint cchUser, [MarshalUsing(CountElementName = nameof(cchPassword))] PWSTR pwszPassword, uint cchPassword, HRESULT hrStatus, out uint pdwFlags);
}
