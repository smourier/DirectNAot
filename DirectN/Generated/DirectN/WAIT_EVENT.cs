#nullable enable
namespace DirectN;

public enum WAIT_EVENT : uint
{
    WAIT_OBJECT_0 = 0,
    WAIT_ABANDONED = 128,
    WAIT_ABANDONED_0 = 128,
    WAIT_IO_COMPLETION = 192,
    WAIT_TIMEOUT = 258,
    WAIT_FAILED = uint.MaxValue,
}
