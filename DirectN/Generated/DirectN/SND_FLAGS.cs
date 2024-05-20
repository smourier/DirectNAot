#nullable enable
namespace DirectN;

[Flags]
public enum SND_FLAGS : uint
{
    SND_APPLICATION = 128,
    SND_ALIAS = 65536,
    SND_ALIAS_ID = 1114112,
    SND_FILENAME = 131072,
    SND_RESOURCE = 262148,
    SND_ASYNC = 1,
    SND_NODEFAULT = 2,
    SND_LOOP = 8,
    SND_MEMORY = 4,
    SND_NOSTOP = 16,
    SND_NOWAIT = 8192,
    SND_PURGE = 64,
    SND_SENTRY = 524288,
    SND_SYNC = 0,
    SND_SYSTEM = 2097152,
}
