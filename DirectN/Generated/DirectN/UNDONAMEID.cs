#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ne-richedit-undonameid
public enum UNDONAMEID
{
    UID_UNKNOWN = 0,
    UID_TYPING = 1,
    UID_DELETE = 2,
    UID_DRAGDROP = 3,
    UID_CUT = 4,
    UID_PASTE = 5,
    UID_AUTOTABLE = 6,
}
