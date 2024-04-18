namespace DirectN;

[GeneratedComInterface, Guid("214685f6-7b78-4681-87e0-495f739273d1")]
public partial interface IPrinterQueueEvent : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OnBidiResponseReceived(BSTR bstrResponse, [MarshalAs(UnmanagedType.Error)] HRESULT hrStatus);
}
