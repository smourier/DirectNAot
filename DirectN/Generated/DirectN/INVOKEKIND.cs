#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-invokekind
public enum INVOKEKIND
{
    INVOKE_FUNC = 1,
    INVOKE_PROPERTYGET = 2,
    INVOKE_PROPERTYPUT = 4,
    INVOKE_PROPERTYPUTREF = 8,
}
