#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsprint/ns-xpsprint-xps_job_status
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_JOB_STATUS
{
    public uint jobId;
    public int currentDocument;
    public int currentPage;
    public int currentPageTotal;
    public XPS_JOB_COMPLETION completion;
    public HRESULT jobStatus;
}
