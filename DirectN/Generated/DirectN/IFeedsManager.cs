#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a74029cc-1f1a-4906-88f0-810638d86591")]
public partial interface IFeedsManager : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RootFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSubscribed(BSTR feedUrl, out VARIANT_BOOL subscribed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFeed(BSTR feedPath, out VARIANT_BOOL exists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeed(BSTR feedPath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeedByUrl(BSTR feedUrl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFolder(BSTR folderPath, out VARIANT_BOOL exists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(BSTR folderPath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFeed(BSTR feedPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFolder(BSTR folderPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BackgroundSync(FEEDS_BACKGROUNDSYNC_ACTION action);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BackgroundSyncStatus(out FEEDS_BACKGROUNDSYNC_STATUS status);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultInterval(out int minutes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultInterval(int minutes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AsyncSyncAll();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Normalize(BSTR feedXmlIn, out BSTR feedXmlOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ItemCountLimit(out int itemCountLimit);
}
