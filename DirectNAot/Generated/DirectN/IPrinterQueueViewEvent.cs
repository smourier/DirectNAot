namespace DirectN;

[GeneratedComInterface, Guid("c5b6042b-fd21-404a-a0ef-e2fbb52b9080")]
public partial interface IPrinterQueueViewEvent : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OnChanged(IPrintJobCollection pCollection, uint ulViewOffset, uint ulViewSize, uint ulCountJobsInPrintQueue);
}
