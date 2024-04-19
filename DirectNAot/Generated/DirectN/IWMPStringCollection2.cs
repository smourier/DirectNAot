namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpstringcollection2
[GeneratedComInterface, Guid("46ad648d-53f1-4a74-92e2-2a1b68d63fd4")]
public partial interface IWMPStringCollection2 : IWMPStringCollection
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection2-isidentical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isIdentical(IWMPStringCollection2 pIWMPStringCollection2, ref VARIANT_BOOL pvbool);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection2-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(int lCollectionIndex, BSTR bstrItemName, ref BSTR pbstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection2-getattributecountbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAttributeCountByType(int lCollectionIndex, BSTR bstrType, BSTR bstrLanguage, ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpstringcollection2-getiteminfobytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfoByType(int lCollectionIndex, BSTR bstrType, BSTR bstrLanguage, int lAttributeIndex, ref VARIANT pvarValue);
}
