namespace DirectN;

[GeneratedComInterface, Guid("2933bf85-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMAttribute : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_name(out BSTR attributeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_value(out VARIANT attributeValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_value(VARIANT attributeValue);
}
