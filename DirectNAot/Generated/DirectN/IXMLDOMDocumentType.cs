namespace DirectN;

[GeneratedComInterface, Guid("2933bf8b-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMDocumentType : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_name(out BSTR rootName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_entities(out IXMLDOMNamedNodeMap entityMap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_notations(out IXMLDOMNamedNodeMap notationMap);
}
