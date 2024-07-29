#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("abf35c99-0681-47ea-9a8c-1436a375a99e")]
public partial interface IFeedEvents : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Error();
    
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
    HRESULT FeedMoved(BSTR path, BSTR oldPath);
    
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
