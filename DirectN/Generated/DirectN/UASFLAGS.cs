#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ne-ocidl-uasflags
public enum UASFLAGS
{
    UAS_NORMAL = 0,
    UAS_BLOCKED = 1,
    UAS_NOPARENTENABLE = 2,
    UAS_MASK = 3,
}
