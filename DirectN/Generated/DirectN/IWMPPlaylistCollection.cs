#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplaylistcollection
[GeneratedComInterface, Guid("10a13217-23a7-439b-b1c0-d847c79b7774")]
public partial interface IWMPPlaylistCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-newplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT newPlaylist(BSTR bstrName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] out IWMPPlaylist ppItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-getall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAll([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylistArray>))] out IWMPPlaylistArray ppPlaylistArray);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-getbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByName(BSTR bstrName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylistArray>))] out IWMPPlaylistArray ppPlaylistArray);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove(IWMPPlaylist pItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplaylistcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setDeleted(IWMPPlaylist pItem, VARIANT_BOOL varfIsDeleted);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-isdeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isDeleted(IWMPPlaylist pItem, ref VARIANT_BOOL pvarfIsDeleted);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylistcollection-importplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT importPlaylist(IWMPPlaylist pItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] out IWMPPlaylist ppImportedItem);
}
