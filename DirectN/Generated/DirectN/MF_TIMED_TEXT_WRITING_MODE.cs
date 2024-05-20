#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_timed_text_writing_mode
public enum MF_TIMED_TEXT_WRITING_MODE
{
    MF_TIMED_TEXT_WRITING_MODE_LRTB = 0,
    MF_TIMED_TEXT_WRITING_MODE_RLTB = 1,
    MF_TIMED_TEXT_WRITING_MODE_TBRL = 2,
    MF_TIMED_TEXT_WRITING_MODE_TBLR = 3,
    MF_TIMED_TEXT_WRITING_MODE_LR = 4,
    MF_TIMED_TEXT_WRITING_MODE_RL = 5,
    MF_TIMED_TEXT_WRITING_MODE_TB = 6,
}
