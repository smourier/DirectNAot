#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1630852e-1263-465b-98e5-fe60ffec4ac2")]
public partial interface IXFeedEvents
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Error();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDeleted(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedRenamed(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedUrlChanged(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedMoved(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDownloading(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDownloadCompleted(PWSTR pszPath, FEEDS_DOWNLOAD_ERROR fde);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedItemCountChanged(PWSTR pszPath, int feicfFlags);
}
