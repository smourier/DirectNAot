namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsprint/ne-xpsprint-xps_job_completion
public enum XPS_JOB_COMPLETION
{
    XPS_JOB_IN_PROGRESS = 0,
    XPS_JOB_COMPLETED = 1,
    XPS_JOB_CANCELLED = 2,
    XPS_JOB_FAILED = 3,
}
