namespace DirectN;

[GeneratedComInterface, Guid("2933bf80-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMNode : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nodeName(out BSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nodeValue(out VARIANT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_nodeValue(VARIANT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nodeType(out DOMNodeType type);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_parentNode(out IXMLDOMNode parent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_childNodes(out IXMLDOMNodeList childList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_firstChild(out IXMLDOMNode firstChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_lastChild(out IXMLDOMNode lastChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_previousSibling(out IXMLDOMNode previousSibling);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nextSibling(out IXMLDOMNode nextSibling);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_attributes(out IXMLDOMNamedNodeMap attributeMap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT insertBefore(IXMLDOMNode newChild, VARIANT refChild, out IXMLDOMNode outNewChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT replaceChild(IXMLDOMNode newChild, IXMLDOMNode oldChild, out IXMLDOMNode outOldChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT removeChild(IXMLDOMNode childNode, out IXMLDOMNode oldChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT appendChild(IXMLDOMNode newChild, out IXMLDOMNode outNewChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT hasChildNodes(out VARIANT_BOOL hasChild);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ownerDocument(out IXMLDOMDocument XMLDOMDocument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT cloneNode(VARIANT_BOOL deep, out IXMLDOMNode cloneRoot);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nodeTypeString(out BSTR nodeType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_text(out BSTR text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_text(BSTR text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_specified(out VARIANT_BOOL isSpecified);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_definition(out IXMLDOMNode definitionNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_nodeTypedValue(out VARIANT typedValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_dataType(out VARIANT dataTypeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_dataType(BSTR dataTypeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_xml(out BSTR xmlString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT transformNode(IXMLDOMNode stylesheet, out BSTR xmlString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT selectNodes(BSTR queryString, out IXMLDOMNodeList resultList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT selectSingleNode(BSTR queryString, out IXMLDOMNode resultNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_parsed(out VARIANT_BOOL isParsed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_namespaceURI(out BSTR namespaceURI);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_prefix(out BSTR prefixString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_baseName(out BSTR nameString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT transformNodeToObject(IXMLDOMNode stylesheet, VARIANT outputObject);
}
