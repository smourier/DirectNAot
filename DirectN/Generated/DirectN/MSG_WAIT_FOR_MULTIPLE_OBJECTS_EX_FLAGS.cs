#nullable enable
namespace DirectN;

[Flags]
public enum MSG_WAIT_FOR_MULTIPLE_OBJECTS_EX_FLAGS : uint
{
    MWMO_NONE = 0,
    MWMO_ALERTABLE = 2,
    MWMO_INPUTAVAILABLE = 4,
    MWMO_WAITALL = 1,
}
