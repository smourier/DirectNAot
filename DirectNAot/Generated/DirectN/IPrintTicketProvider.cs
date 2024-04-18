namespace DirectN;

[GeneratedComInterface, Guid("bb5116db-0a23-4c3a-a6b6-89e5558dfb5d")]
public partial interface IPrintTicketProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSupportedVersions(HANDLE hPrinter, ref int ppVersions, ref int cVersions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BindPrinter(HANDLE hPrinter, int version, ref SHIMOPTS pOptions, ref uint pDevModeFlags, ref int cNamespaces, ref BSTR ppNamespaces);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryDeviceNamespace(ref BSTR pDefaultNamespace);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ConvertPrintTicketToDevMode(IXMLDOMDocument2 pPrintTicket, uint cbDevmodeIn, ref DEVMODEA pDevmodeIn, ref uint pcbDevmodeOut, ref DEVMODEA ppDevmodeOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ConvertDevModeToPrintTicket(uint cbDevmode, ref DEVMODEA pDevmode, IXMLDOMDocument2 pPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintCapabilities(IXMLDOMDocument2 pPrintTicket, out IXMLDOMDocument2 ppCapabilities);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ValidatePrintTicket(IXMLDOMDocument2 pBaseTicket);
}
