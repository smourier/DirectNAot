namespace DirectN;

[GeneratedComInterface, Guid("0e8f51b8-8273-4906-8e7b-be453ffd2e2b")]
public partial interface IBidiSpl2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BindDevice(PWSTR pszDeviceName, uint dwAccess);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnbindDevice();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendRecvXMLString(BSTR bstrRequest, out BSTR pbstrResponse);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendRecvXMLStream(IStream pSRequest, out IStream ppSResponse);
}
