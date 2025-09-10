#nullable enable
namespace DirectN;

public enum EPolicyAction
{
    eNoAction = 0,
    eThrowException = 1,
    eAbortThread = 2,
    eRudeAbortThread = 3,
    eUnloadAppDomain = 4,
    eRudeUnloadAppDomain = 5,
    eExitProcess = 6,
    eFastExitProcess = 7,
    eRudeExitProcess = 8,
    eDisableRuntime = 9,
    MaxPolicyAction = 10,
}
