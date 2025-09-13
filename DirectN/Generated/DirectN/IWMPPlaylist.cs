#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplaylist
[GeneratedComInterface, Guid("d5f0f4f1-130c-11d3-b14e-00c04f79faa6")]
public partial interface IWMPPlaylist : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_name(out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-put_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_name(BSTR bstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_attributecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_attributeCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_attributename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_attributeName(int lIndex, out BSTR pbstrAttributeName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_item(int lIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] out IWMPMedia ppIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrName, out BSTR pbstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-setiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setItemInfo(BSTR bstrName, BSTR bstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-get_isidentical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isIdentical([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pIWMPPlaylist, ref VARIANT_BOOL pvbool);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT clear();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-insertitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT insertItem(int lIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-appenditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT appendItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-removeitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT removeItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplaylist-moveitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT moveItem(int lIndexOld, int lIndexNew);
}
