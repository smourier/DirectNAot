#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecureauthenticate
[GeneratedComInterface, Guid("1dcb3a0f-33ed-11d3-8470-00c04f79dbc0")]
public partial interface ISCPSecureAuthenticate
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureauthenticate-getsecurequery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecureQuery([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISCPSecureQuery>))] out ISCPSecureQuery ppSecureQuery);
}
