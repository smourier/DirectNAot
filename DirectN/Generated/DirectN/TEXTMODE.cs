#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ne-richedit-textmode
public enum TEXTMODE
{
    TM_PLAINTEXT = 1,
    TM_RICHTEXT = 2,
    TM_SINGLELEVELUNDO = 4,
    TM_MULTILEVELUNDO = 8,
    TM_SINGLECODEPAGE = 16,
    TM_MULTICODEPAGE = 32,
}
