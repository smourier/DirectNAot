namespace DirectN;

[GeneratedComInterface, Guid("3efaa426-272f-11d2-836f-0000f87a7782")]
public partial interface IXMLDOMParseError : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_errorCode(out int errorCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_url(out BSTR urlString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_reason(out BSTR reasonString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_srcText(out BSTR sourceString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_line(out int lineNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_linepos(out int linePosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_filepos(out int filePosition);
}
