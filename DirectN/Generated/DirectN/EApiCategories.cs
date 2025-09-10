#nullable enable
namespace DirectN;

public enum EApiCategories
{
    eNoChecks = 0,
    eSynchronization = 1,
    eSharedState = 2,
    eExternalProcessMgmt = 4,
    eSelfAffectingProcessMgmt = 8,
    eExternalThreading = 16,
    eSelfAffectingThreading = 32,
    eSecurityInfrastructure = 64,
    eUI = 128,
    eMayLeakOnAbort = 256,
    eAll = 511,
}
