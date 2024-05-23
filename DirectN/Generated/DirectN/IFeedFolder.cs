#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("81f04ad1-4194-4d7d-86d6-11813cec163c")]
public partial interface IFeedFolder : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Feeds([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subfolders([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFeed(BSTR feedName, BSTR feedUrl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSubfolder(BSTR folderName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFeed(BSTR feedName, out VARIANT_BOOL exists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeed(BSTR feedName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsSubfolder(BSTR folderName, out VARIANT_BOOL exists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubfolder(BSTR folderName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR folderName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rename(BSTR folderName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR folderPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(BSTR newParentPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsRoot(out VARIANT_BOOL isRoot);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TotalUnreadItemCount(out int count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TotalItemCount(out int count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWatcher(FEEDS_EVENTS_SCOPE scope, FEEDS_EVENTS_MASK mask, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
}
