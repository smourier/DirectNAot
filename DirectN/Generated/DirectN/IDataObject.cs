#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-idataobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010e-0000-0000-c000-000000000046")]
public partial interface IDataObject
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(in FORMATETC pformatetcIn, out STGMEDIUM pmedium);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-getdatahere
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataHere(in FORMATETC pformatetc, ref STGMEDIUM pmedium);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-querygetdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryGetData(in FORMATETC pformatetc);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-getcanonicalformatetc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCanonicalFormatEtc(in FORMATETC pformatectIn, out FORMATETC pformatetcOut);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-setdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetData(in FORMATETC pformatetc, in STGMEDIUM pmedium, BOOL fRelease);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-enumformatetc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFormatEtc(uint dwDirection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumFORMATETC>))] out IEnumFORMATETC ppenumFormatEtc);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-dadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DAdvise(in FORMATETC pformatetc, uint advf, IAdviseSink pAdvSink, out uint pdwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-dunadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DUnadvise(uint dwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataobject-enumdadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDAdvise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATDATA>))] out IEnumSTATDATA ppenumAdvise);
}
