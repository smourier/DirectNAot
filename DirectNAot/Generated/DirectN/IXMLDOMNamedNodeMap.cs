namespace DirectN;

[GeneratedComInterface, Guid("2933bf83-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMNamedNodeMap : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getNamedItem(BSTR name, out IXMLDOMNode namedItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT setNamedItem(IXMLDOMNode newItem, out IXMLDOMNode nameItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT removeNamedItem(BSTR name, out IXMLDOMNode namedItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_item(int index, out IXMLDOMNode listItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_length(out int listLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getQualifiedItem(BSTR baseName, BSTR namespaceURI, out IXMLDOMNode qualifiedItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT removeQualifiedItem(BSTR baseName, BSTR namespaceURI, out IXMLDOMNode qualifiedItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT nextNode(out IXMLDOMNode nextItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get__newEnum(out nint ppUnk);
}
