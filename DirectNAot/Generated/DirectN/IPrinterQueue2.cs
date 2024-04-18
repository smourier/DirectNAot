namespace DirectN;

[GeneratedComInterface, Guid("8cd444e8-c9bb-49b3-8e38-e03209416131")]
public partial interface IPrinterQueue2 : IPrinterQueue
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SendBidiSetRequestAsync(BSTR bstrBidiRequest, IPrinterBidiSetRequestCallback pCallback, out IPrinterExtensionAsyncOperation ppAsyncOperation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrinterQueueView(uint ulViewOffset, uint ulViewSize, out IPrinterQueueView ppJobView);
}
