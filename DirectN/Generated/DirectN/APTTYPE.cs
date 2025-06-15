#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/ne-objidlbase-apttype
public enum APTTYPE
{
    APTTYPE_CURRENT = -1,
    APTTYPE_STA = 0,
    APTTYPE_MTA = 1,
    APTTYPE_NA = 2,
    APTTYPE_MAINSTA = 3,
}
