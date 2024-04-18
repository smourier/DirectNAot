namespace DirectN;

[GeneratedComInterface, Guid("39843bf3-c4d2-41fd-b4b2-aedbee5e1900")]
public partial interface IPrinterExtensionRequest : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Cancel([MarshalAs(UnmanagedType.Error)] HRESULT hrStatus, BSTR bstrLogMessage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Complete();
}
