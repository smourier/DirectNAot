#nullable enable
namespace DirectN;

public enum ETaskType
{
    TT_DEBUGGERHELPER = 1,
    TT_GC = 2,
    TT_FINALIZER = 4,
    TT_THREADPOOL_TIMER = 8,
    TT_THREADPOOL_GATE = 16,
    TT_THREADPOOL_WORKER = 32,
    TT_THREADPOOL_IOCOMPLETION = 64,
    TT_ADUNLOAD = 128,
    TT_USER = 256,
    TT_THREADPOOL_WAIT = 512,
    TT_UNKNOWN = int.MinValue,
}
