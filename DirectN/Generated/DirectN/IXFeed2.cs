#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ce528e77-3716-4eb7-956d-f5e37502e12a")]
public partial interface IXFeed2 : IXFeed
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemByEffectiveId(uint uiEffectiveId, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastItemDownloadTime(out SYSTEMTIME pstLastItemDownloadTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Username(out PWSTR ppszUsername);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Password(out PWSTR ppszPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentials(PWSTR pszUsername, PWSTR pszPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearCredentials();
}
