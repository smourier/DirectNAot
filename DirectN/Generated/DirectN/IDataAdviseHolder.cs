#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-idataadviseholder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000110-0000-0000-c000-000000000046")]
public partial interface IDataAdviseHolder
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataadviseholder-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject?>))] IDataObject? pDataObject, in FORMATETC pFetc, uint advf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAdviseSink>))] IAdviseSink pAdvise, out uint pdwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataadviseholder-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataadviseholder-enumadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdvise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATDATA>))] out IEnumSTATDATA ppenumAdvise);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-idataadviseholder-sendondatachange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOnDataChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject, uint dwReserved, uint advf);
}
