#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ne-richedit-khyph
public enum KHYPH
{
    khyphNil = 0,
    khyphNormal = 1,
    khyphAddBefore = 2,
    khyphChangeBefore = 3,
    khyphDeleteBefore = 4,
    khyphChangeAfter = 5,
    khyphDelAndChange = 6,
}
