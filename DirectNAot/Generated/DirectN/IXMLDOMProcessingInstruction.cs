namespace DirectN;

[GeneratedComInterface, Guid("2933bf89-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMProcessingInstruction : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_target(out BSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_data(out BSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_data(BSTR value);
}
