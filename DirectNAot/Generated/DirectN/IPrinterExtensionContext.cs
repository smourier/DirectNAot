namespace DirectN;

[GeneratedComInterface, Guid("39843bf2-c4d2-41fd-b4b2-aedbee5e1900")]
public partial interface IPrinterExtensionContext : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_PrinterQueue(out IPrinterQueue ppQueue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_PrintSchemaTicket(out IPrintSchemaTicket ppTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DriverProperties(out IPrinterPropertyBag ppPropertyBag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_UserProperties(out IPrinterPropertyBag ppPropertyBag);
}
