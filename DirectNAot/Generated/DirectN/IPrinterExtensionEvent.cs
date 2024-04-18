namespace DirectN;

[GeneratedComInterface, Guid("c093cb63-5ef5-4585-af8e-4d5637487b57")]
public partial interface IPrinterExtensionEvent : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OnDriverEvent(IPrinterExtensionEventArgs pEventArgs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OnPrinterQueuesEnumerated(IPrinterExtensionContextCollection pContextCollection);
}
