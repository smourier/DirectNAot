#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a44179a4-e0f6-403b-af8d-d080f425a451")]
public partial interface IXFeed
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Xml(uint uiItemCount, FEEDS_XML_SORT_PROPERTY sortProperty, FEEDS_XML_SORT_ORDER sortOrder, FEEDS_XML_FILTER_FLAGS filterFlags, FEEDS_XML_INCLUDE_FLAGS includeFlags, out IStream pps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Name(out PWSTR ppszName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rename(PWSTR pszName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Url(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUrl(PWSTR pszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LocalId(out Guid pguid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Path(out PWSTR ppszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Parent(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastWriteTime(out SYSTEMTIME pstLastWriteTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Download();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AsyncDownload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelAsyncDownload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncSetting(out FEEDS_SYNC_SETTING pfss);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncSetting(FEEDS_SYNC_SETTING fss);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Interval(out uint puiInterval);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInterval(uint uiInterval);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastDownloadTime(out SYSTEMTIME pstLastDownloadTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LocalEnclosurePath(out PWSTR ppszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Items(out IXFeedsEnum ppfe);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(uint uiId, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MarkAllItemsRead();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MaxItemCount(out uint puiMaxItemCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxItemCount(uint uiMaxItemCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadEnclosuresAutomatically([MarshalAs(UnmanagedType.U4)] out bool pbDownloadEnclosuresAutomatically);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDownloadEnclosuresAutomatically([MarshalAs(UnmanagedType.U4)] bool bDownloadEnclosuresAutomatically);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadStatus(out FEEDS_DOWNLOAD_STATUS pfds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastDownloadError(out FEEDS_DOWNLOAD_ERROR pfde);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Merge(IStream pStream, PWSTR pszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadUrl(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Title(out PWSTR ppszTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Description(out PWSTR ppszDescription);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Link(out PWSTR ppszHomePage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Image(out PWSTR ppszImageUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastBuildDate(out SYSTEMTIME pstLastBuildDate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PubDate(out SYSTEMTIME pstPubDate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Ttl(out uint puiTtl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Language(out PWSTR ppszLanguage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Copyright(out PWSTR ppszCopyright);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsList([MarshalAs(UnmanagedType.U4)] out bool pbIsList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWatcher(FEEDS_EVENTS_SCOPE scope, FEEDS_EVENTS_MASK mask, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnreadItemCount(out uint puiUnreadItemCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ItemCount(out uint puiItemCount);
}
