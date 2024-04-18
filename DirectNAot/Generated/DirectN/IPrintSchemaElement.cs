namespace DirectN;

[GeneratedComInterface, Guid("724c1646-e64b-4bbf-8eb4-d45e4fd580da")]
public partial interface IPrintSchemaElement : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_XmlNode(out nint ppXmlNode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Name(out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_NamespaceUri(out BSTR pbstrNamespaceUri);
}
