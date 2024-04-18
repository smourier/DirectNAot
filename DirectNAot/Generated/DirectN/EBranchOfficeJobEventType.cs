namespace DirectN;

public enum EBranchOfficeJobEventType
{
    kInvalidJobState = 0,
    kLogJobPrinted = 1,
    kLogJobRendered = 2,
    kLogJobError = 3,
    kLogJobPipelineError = 4,
    kLogOfflineFileFull = 5,
}
