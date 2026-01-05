#nullable enable
namespace DirectN;

[Flags]
public enum HOT_KEY_MODIFIERS : uint
{
    MOD_ALT = 1,
    MOD_CONTROL = 2,
    MOD_NOREPEAT = 16384,
    MOD_SHIFT = 4,
    MOD_WIN = 8,
}
