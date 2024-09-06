#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("20a59fa6-a844-4630-9e98-175f70b4d55b")]
public partial interface IFeedFolderEvents : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Error();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderAdded(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderDeleted(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderRenamed(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderMovedFrom(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderMovedTo(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderItemCountChanged(BSTR path, int itemCountType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedAdded(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDeleted(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedRenamed(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedUrlChanged(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedMovedFrom(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedMovedTo(BSTR path, BSTR oldPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDownloading(BSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedDownloadCompleted(BSTR path, FEEDS_DOWNLOAD_ERROR error);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FeedItemCountChanged(BSTR path, int itemCountType);
}
