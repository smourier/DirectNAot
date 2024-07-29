#nullable enable
namespace DirectN;

[Flags]
public enum DUPLICATE_HANDLE_OPTIONS : uint
{
    DUPLICATE_CLOSE_SOURCE = 1,
    DUPLICATE_SAME_ACCESS = 2,
}
