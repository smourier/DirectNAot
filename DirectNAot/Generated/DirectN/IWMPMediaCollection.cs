namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmediacollection
[GeneratedComInterface, Guid("8363bc22-b4b4-4b19-989d-1cd765749dd1")]
public partial interface IWMPMediaCollection : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add(BSTR bstrURL, out IWMPMedia ppItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAll(out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByName(BSTR bstrName, out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getbygenre
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByGenre(BSTR bstrGenre, out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getbyauthor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByAuthor(BSTR bstrAuthor, out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getbyalbum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByAlbum(BSTR bstrAlbum, out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getbyattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByAttribute(BSTR bstrAttribute, BSTR bstrValue, out IWMPPlaylist ppMediaItems);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove(IWMPMedia pItem, VARIANT_BOOL varfDeleteFile);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getattributestringcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAttributeStringCollection(BSTR bstrAttribute, BSTR bstrMediaType, out IWMPStringCollection ppStringCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-getmediaatom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getMediaAtom(BSTR bstrItemName, ref int plAtom);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection-setdeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setDeleted(IWMPMedia pItem, VARIANT_BOOL varfIsDeleted);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmediacollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isDeleted(IWMPMedia pItem, ref VARIANT_BOOL pvarfIsDeleted);
}
