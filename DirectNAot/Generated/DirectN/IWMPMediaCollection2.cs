namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmediacollection2
[GeneratedComInterface, Guid("8ba957f5-fd8c-4791-b82d-f840401ee474")]
public partial interface IWMPMediaCollection2 : IWMPMediaCollection
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection2-createquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT createQuery(out IWMPQuery ppQuery);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection2-getplaylistbyquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getPlaylistByQuery(IWMPQuery pQuery, BSTR bstrMediaType, BSTR bstrSortAttribute, VARIANT_BOOL fSortAscending, out IWMPPlaylist ppPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection2-getstringcollectionbyquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getStringCollectionByQuery(BSTR bstrAttribute, IWMPQuery pQuery, BSTR bstrMediaType, BSTR bstrSortAttribute, VARIANT_BOOL fSortAscending, out IWMPStringCollection ppStringCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmediacollection2-getbyattributeandmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getByAttributeAndMediaType(BSTR bstrAttribute, BSTR bstrValue, BSTR bstrMediaType, out IWMPPlaylist ppMediaItems);
}
