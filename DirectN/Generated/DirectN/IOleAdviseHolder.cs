#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleadviseholder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000111-0000-0000-c000-000000000046")]
public partial interface IOleAdviseHolder
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAdviseSink>))] IAdviseSink pAdvise, out uint pdwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwConnection);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-enumadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdvise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATDATA>))] out IEnumSTATDATA ppenumAdvise);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-sendonrename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOnRename([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-sendonsave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOnSave();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleadviseholder-sendonclose
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendOnClose();
}
