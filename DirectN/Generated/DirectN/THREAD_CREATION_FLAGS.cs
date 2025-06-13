#nullable enable
namespace DirectN;

[Flags]
public enum THREAD_CREATION_FLAGS : uint
{
    THREAD_CREATE_RUN_IMMEDIATELY = 0,
    THREAD_CREATE_SUSPENDED = 4,
    STACK_SIZE_PARAM_IS_A_RESERVATION = 65536,
}
