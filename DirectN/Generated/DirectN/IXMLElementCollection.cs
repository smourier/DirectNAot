#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msxml/nn-msxml-ixmlelementcollection
[GeneratedComInterface, Guid("65725580-9b5d-11d0-9bfe-00c04fc99c8e")]
public partial interface IXMLElementCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_length(int v);
    
    // https://learn.microsoft.com/windows/win32/api/msxml/nf-msxml-ixmlelementcollection-get_length
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_length(out int p);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__newEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/msxml/nf-msxml-ixmlelementcollection-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(VARIANT var1, VARIANT var2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
}
