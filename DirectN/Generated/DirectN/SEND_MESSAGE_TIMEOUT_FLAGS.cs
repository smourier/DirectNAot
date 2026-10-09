#nullable enable
namespace DirectN;

[Flags]
public enum SEND_MESSAGE_TIMEOUT_FLAGS : uint
{
    SMTO_ABORTIFHUNG = 2,
    SMTO_BLOCK = 1,
    SMTO_NORMAL = 0,
    SMTO_NOTIMEOUTIFNOTHUNG = 8,
    SMTO_ERRORONEXIT = 32,
}
