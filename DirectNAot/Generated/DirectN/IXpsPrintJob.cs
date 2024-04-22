namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsprint/nn-xpsprint-ixpsprintjob
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5ab89b06-8194-425f-ab3b-d7a96e350161")]
public partial interface IXpsPrintJob
{
    // https://learn.microsoft.com/windows/win32/api/xpsprint/nf-xpsprint-ixpsprintjob-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/xpsprint/nf-xpsprint-ixpsprintjob-getjobstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJobStatus(out XPS_JOB_STATUS jobStatus);
}
