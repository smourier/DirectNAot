namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/job-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct JOB_INFO_3
{
    public uint JobId;
    public uint NextJobId;
    public uint Reserved;
}
