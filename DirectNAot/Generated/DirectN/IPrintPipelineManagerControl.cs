namespace DirectN;

[GeneratedComInterface, Guid("aa3e4910-5889-4681-91ef-823ad4ed4e44")]
public partial interface IPrintPipelineManagerControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RequestShutdown([MarshalAs(UnmanagedType.Error)] HRESULT hrReason, IImgErrorInfo pReason);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FilterFinished();
}
