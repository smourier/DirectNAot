namespace DirectN;

[GeneratedComInterface, Guid("476e2969-3b2b-4b3f-8277-cff6056042aa")]
public partial interface IPrinterQueueView : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetViewRange(uint ulViewOffset, uint ulViewSize);
}
