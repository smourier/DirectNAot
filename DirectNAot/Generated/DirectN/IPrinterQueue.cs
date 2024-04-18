namespace DirectN;

[GeneratedComInterface, Guid("3580a828-07fe-4b94-ac1a-757d9d2d3056")]
public partial interface IPrinterQueue : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Handle(out HANDLE phPrinter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Name(out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendBidiQuery(BSTR bstrBidiQuery);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetProperties(out IPrinterPropertyBag ppPropertyBag);
}
