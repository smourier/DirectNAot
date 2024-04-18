namespace DirectN;

[GeneratedComInterface, Guid("23adbb16-0133-4906-b29a-1dce1d026379")]
public partial interface IPrintSchemaAsyncOperationEvent : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Completed(IPrintSchemaTicket pTicket, [MarshalAs(UnmanagedType.Error)] HRESULT hrOperation);
}
