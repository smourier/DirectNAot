#nullable enable
namespace DirectN;

[Flags]
public enum DI_FLAGS : uint
{
    DI_MASK = 1,
    DI_IMAGE = 2,
    DI_NORMAL = 3,
    DI_COMPAT = 4,
    DI_DEFAULTSIZE = 8,
    DI_NOMIRROR = 16,
}
