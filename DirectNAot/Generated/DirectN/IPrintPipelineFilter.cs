namespace DirectN;

[GeneratedComInterface, Guid("cdb62fc0-8bed-434e-86fb-a2cae55f19ea")]
public partial interface IPrintPipelineFilter
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InitializeFilter(IInterFilterCommunicator pINegotiation, IPrintPipelinePropertyBag pIPropertyBag, IPrintPipelineManagerControl pIPipelineControl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ShutdownOperation();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StartOperation();
}
