namespace DirectN;

[GeneratedComInterface, Guid("2933bf81-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMDocument : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_doctype(out IXMLDOMDocumentType documentType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_implementation(out IXMLDOMImplementation impl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_documentElement(out IXMLDOMElement DOMElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT putref_documentElement(IXMLDOMElement DOMElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createElement(BSTR tagName, out IXMLDOMElement element);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createDocumentFragment(out IXMLDOMDocumentFragment docFrag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createTextNode(BSTR data, out IXMLDOMText text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createComment(BSTR data, out IXMLDOMComment comment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createCDATASection(BSTR data, out IXMLDOMCDATASection cdata);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createProcessingInstruction(BSTR target, BSTR data, out IXMLDOMProcessingInstruction pi);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createAttribute(BSTR name, out IXMLDOMAttribute attribute);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createEntityReference(BSTR name, out IXMLDOMEntityReference entityRef);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getElementsByTagName(BSTR tagName, out IXMLDOMNodeList resultList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT createNode(VARIANT Type, BSTR name, BSTR namespaceURI, out IXMLDOMNode node);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT nodeFromID(BSTR idString, out IXMLDOMNode node);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT load(VARIANT xmlSource, out VARIANT_BOOL isSuccessful);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_readyState(out int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_parseError(out IXMLDOMParseError errorObj);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_url(out BSTR urlString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_async(out VARIANT_BOOL isAsync);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_async(VARIANT_BOOL isAsync);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT abort();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT loadXML(BSTR bstrXML, out VARIANT_BOOL isSuccessful);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT save(VARIANT destination);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_validateOnParse(out VARIANT_BOOL isValidating);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_validateOnParse(VARIANT_BOOL isValidating);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_resolveExternals(out VARIANT_BOOL isResolving);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_resolveExternals(VARIANT_BOOL isResolving);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_preserveWhiteSpace(out VARIANT_BOOL isPreserving);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_preserveWhiteSpace(VARIANT_BOOL isPreserving);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_onreadystatechange(VARIANT readystatechangeSink);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_ondataavailable(VARIANT ondataavailableSink);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_ontransformnode(VARIANT ontransformnodeSink);
}
