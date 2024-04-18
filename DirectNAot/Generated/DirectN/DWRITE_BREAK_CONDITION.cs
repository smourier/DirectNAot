namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_break_condition
public enum DWRITE_BREAK_CONDITION
{
    DWRITE_BREAK_CONDITION_NEUTRAL = 0,
    DWRITE_BREAK_CONDITION_CAN_BREAK = 1,
    DWRITE_BREAK_CONDITION_MAY_NOT_BREAK = 2,
    DWRITE_BREAK_CONDITION_MUST_BREAK = 3,
}
