namespace DirectN;

[GeneratedComInterface, Guid("066acbca-8881-49c9-bb98-fae16b4889e1")]
public partial interface IPrinterScriptContext : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DriverProperties(out IPrinterScriptablePropertyBag ppPropertyBag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_QueueProperties(out IPrinterScriptablePropertyBag ppPropertyBag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_UserProperties(out IPrinterScriptablePropertyBag ppPropertyBag);
}
