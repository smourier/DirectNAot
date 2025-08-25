#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ne-oleidl-oleclose
public enum OLECLOSE
{
    OLECLOSE_SAVEIFDIRTY = 0,
    OLECLOSE_NOSAVE = 1,
    OLECLOSE_PROMPTSAVE = 2,
}
