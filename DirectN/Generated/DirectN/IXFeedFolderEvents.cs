#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7964b769-234a-4bb1-a5f4-90454c8ad07e")]
public partial interface IXFeedFolderEvents
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Error();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderAdded(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderDeleted(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderRenamed(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderMovedFrom(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderMovedTo(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderItemCountChanged(PWSTR pszPath, int feicfFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedAdded(PWSTR pszPath);
    
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
    HRESULT FeedMovedFrom(PWSTR pszPath, PWSTR pszOldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedMovedTo(PWSTR pszPath, PWSTR pszOldPath);
    
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
