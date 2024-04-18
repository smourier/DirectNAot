namespace DirectN;

[GeneratedComInterface, Guid("2933bf84-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMCharacterData : IXMLDOMNode
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_data(out BSTR data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_data(BSTR data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_length(out int dataLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT substringData(int offset, int count, out BSTR data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT appendData(BSTR data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT insertData(int offset, BSTR data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT deleteData(int offset, int count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT replaceData(int offset, int count, BSTR data);
}
