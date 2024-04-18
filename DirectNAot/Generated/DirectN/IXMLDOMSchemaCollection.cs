namespace DirectN;

[GeneratedComInterface, Guid("373984c8-b845-449b-91e7-45ac83036ade")]
public partial interface IXMLDOMSchemaCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT add(BSTR namespaceURI, VARIANT var);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get(BSTR namespaceURI, out IXMLDOMNode schemaNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT remove(BSTR namespaceURI);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_length(out int length);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_namespaceURI(int index, out BSTR length);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT addCollection(IXMLDOMSchemaCollection otherCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get__newEnum(out nint ppUnk);
}
