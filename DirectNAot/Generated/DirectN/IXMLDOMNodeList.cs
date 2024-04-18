namespace DirectN;

[GeneratedComInterface, Guid("2933bf82-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMNodeList : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_item(int index, out IXMLDOMNode listItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_length(out int listLength);
    
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
