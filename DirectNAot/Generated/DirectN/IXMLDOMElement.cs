namespace DirectN;

[GeneratedComInterface, Guid("2933bf86-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMElement : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_tagName(out BSTR tagName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getAttribute(BSTR name, out VARIANT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT setAttribute(BSTR name, VARIANT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT removeAttribute(BSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getAttributeNode(BSTR name, out IXMLDOMAttribute attributeNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT setAttributeNode(IXMLDOMAttribute DOMAttribute, out IXMLDOMAttribute attributeNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT removeAttributeNode(IXMLDOMAttribute DOMAttribute, out IXMLDOMAttribute attributeNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getElementsByTagName(BSTR tagName, out IXMLDOMNodeList resultList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT normalize();
}
