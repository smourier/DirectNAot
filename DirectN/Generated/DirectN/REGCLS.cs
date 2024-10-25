#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/combaseapi/ne-combaseapi-regcls
[Flags]
public enum REGCLS
{
    REGCLS_SINGLEUSE = 0,
    REGCLS_MULTIPLEUSE = 1,
    REGCLS_MULTI_SEPARATE = 2,
    REGCLS_SUSPENDED = 4,
    REGCLS_SURROGATE = 8,
    REGCLS_AGILE = 16,
}
