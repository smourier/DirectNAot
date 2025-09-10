#nullable enable
namespace DirectN;

public enum EClrFailure
{
    FAIL_NonCriticalResource = 0,
    FAIL_CriticalResource = 1,
    FAIL_FatalRuntime = 2,
    FAIL_OrphanedLock = 3,
    FAIL_StackOverflow = 4,
    FAIL_AccessViolation = 5,
    FAIL_CodeContract = 6,
    MaxClrFailure = 7,
}
