#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsession
[GeneratedComInterface, Guid("88a3e6ed-eee4-4619-bbb3-fd4fb62715d1")]
public partial interface ISCPSession
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsession-beginsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginSession([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPDevice?>))] IMDSPDevice? pIDevice, nint /* byte array */ pCtx, uint dwSizeCtx);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsession-endsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSession(nint /* byte array */ pCtx, uint dwSizeCtx);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsession-getsecurequery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecureQuery([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISCPSecureQuery>))] out ISCPSecureQuery ppSecureQuery);
}
