#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000112-0000-0000-c000-000000000046")]
public partial interface IOleObject
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-setclientsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientSite(IOleClientSite pClientSite);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getclientsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleClientSite>))] out IOleClientSite ppClientSite);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-sethostnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHostNames(PWSTR szContainerApp, PWSTR szContainerObj);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close(uint dwSaveOption);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-setmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMoniker(uint dwWhichMoniker, IMoniker pmk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMoniker(uint dwAssign, uint dwWhichMoniker, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-initfromdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitFromData(IDataObject pDataObject, BOOL fCreation, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getclipboarddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipboardData(uint dwReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] out IDataObject ppDataObject);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-doverb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoVerb(int iVerb, in MSG lpmsg, IOleClientSite pActiveSite, int lindex, HWND hwndParent, in RECT lprcPosRect);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-enumverbs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumVerbs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOLEVERB>))] out IEnumOLEVERB ppEnumOleVerb);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-isuptodate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUpToDate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getuserclassid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserClassID(out Guid pClsid);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getusertype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserType(uint dwFormOfType, out PWSTR pszUserType);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-setextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExtent(DVASPECT dwDrawAspect, in SIZE psizel);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtent(DVASPECT dwDrawAspect, out SIZE psizel);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(IAdviseSink pAdvSink, out uint pdwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-enumadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdvise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATDATA>))] out IEnumSTATDATA ppenumAdvise);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-getmiscstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMiscStatus(DVASPECT dwAspect, out OLEMISC pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleobject-setcolorscheme
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorScheme(in LOGPALETTE pLogpal);
}
