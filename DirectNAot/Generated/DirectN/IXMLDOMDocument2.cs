namespace DirectN;

[GeneratedComInterface, Guid("2933bf95-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMDocument2 : IXMLDOMDocument
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_namespaces(out IXMLDOMSchemaCollection namespaceCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_schemas(out VARIANT otherCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT putref_schemas(VARIANT otherCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT validate(out IXMLDOMParseError errorObj);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT setProperty(BSTR name, VARIANT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT getProperty(BSTR name, out VARIANT value);
}
