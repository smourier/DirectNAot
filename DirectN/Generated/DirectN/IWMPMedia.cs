#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmedia
[GeneratedComInterface, Guid("94d55e95-3fac-11d3-b155-00c04f79faa6")]
public partial interface IWMPMedia : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_isidentical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isIdentical([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pIWMPMedia, ref VARIANT_BOOL pvbool);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_sourceurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_sourceURL(ref BSTR pbstrSourceURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_name(ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-put_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_name(BSTR bstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_imagesourcewidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_imageSourceWidth(ref int pWidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_imagesourceheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_imageSourceHeight(ref int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_markercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_markerCount(ref int pMarkerCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-getmarkertime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getMarkerTime(int MarkerNum, ref double pMarkerTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-getmarkername
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getMarkerName(int MarkerNum, ref BSTR pbstrMarkerName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_duration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_duration(ref double pDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_durationstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_durationString(ref BSTR pbstrDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-get_attributecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_attributeCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-getattributename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAttributeName(int lIndex, ref BSTR pbstrItemName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrItemName, ref BSTR pbstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-setiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setItemInfo(BSTR bstrItemName, BSTR bstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-getiteminfobyatom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfoByAtom(int lAtom, ref BSTR pbstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-ismemberof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isMemberOf([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pPlaylist, ref VARIANT_BOOL pvarfIsMemberOf);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia-isreadonlyitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isReadOnlyItem(BSTR bstrItemName, ref VARIANT_BOOL pvarfIsReadOnly);
}
