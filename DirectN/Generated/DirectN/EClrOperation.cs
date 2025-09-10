#nullable enable
namespace DirectN;

public enum EClrOperation
{
    OPR_ThreadAbort = 0,
    OPR_ThreadRudeAbortInNonCriticalRegion = 1,
    OPR_ThreadRudeAbortInCriticalRegion = 2,
    OPR_AppDomainUnload = 3,
    OPR_AppDomainRudeUnload = 4,
    OPR_ProcessExit = 5,
    OPR_FinalizerRun = 6,
    MaxClrOperation = 7,
}
