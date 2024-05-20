#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5357e238-fb12-4aca-a930-cab7832b84bf")]
public partial interface IXFeedsManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RootFolder(in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSubscribed(PWSTR pszUrl, [MarshalAs(UnmanagedType.U4)] out bool pbSubscribed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFeed(PWSTR pszPath, [MarshalAs(UnmanagedType.U4)] out bool pbFeedExists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeed(PWSTR pszPath, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeedByUrl(PWSTR pszUrl, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFolder(PWSTR pszPath, [MarshalAs(UnmanagedType.U4)] out bool pbFolderExists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(PWSTR pszPath, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFeed(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFolder(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BackgroundSync(FEEDS_BACKGROUNDSYNC_ACTION fbsa);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BackgroundSyncStatus(out FEEDS_BACKGROUNDSYNC_STATUS pfbss);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DefaultInterval(out uint puiInterval);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultInterval(uint uiInterval);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AsyncSyncAll();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Normalize(IStream pStreamIn, out IStream ppStreamOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ItemCountLimit(out uint puiItemCountLimit);
}
