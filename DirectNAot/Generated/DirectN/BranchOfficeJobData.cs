namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BranchOfficeJobData
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _JobInfo_e__Union
    {
        [FieldOffset(0)]
        public BranchOfficeJobDataPrinted LogJobPrinted;
        
        [FieldOffset(0)]
        public BranchOfficeJobDataRendered LogJobRendered;
        
        [FieldOffset(0)]
        public BranchOfficeJobDataError LogJobError;
        
        [FieldOffset(0)]
        public BranchOfficeJobDataPipelineFailed LogPipelineFailed;
        
        [FieldOffset(0)]
        public BranchOfficeLogOfflineFileFull LogOfflineFileFull;
    }
    
    public EBranchOfficeJobEventType eEventType;
    public uint JobId;
    public _JobInfo_e__Union JobInfo;
}
