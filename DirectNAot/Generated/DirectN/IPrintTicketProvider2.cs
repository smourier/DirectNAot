namespace DirectN;

[GeneratedComInterface, Guid("b8a70ab2-3dfc-4fec-a074-511b13c651cb")]
public partial interface IPrintTicketProvider2 : IPrintTicketProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintDeviceCapabilities(IXMLDOMDocument2 pPrintTicket, out IXMLDOMDocument2 ppDeviceCapabilities);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintDeviceResources(PWSTR pszLocaleName, IXMLDOMDocument2 pPrintTicket, out IXMLDOMDocument2 ppDeviceResources);
}
