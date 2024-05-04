#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-varkind
public enum VARKIND
{
    VAR_PERINSTANCE = 0,
    VAR_STATIC = 1,
    VAR_CONST = 2,
    VAR_DISPATCH = 3,
}
