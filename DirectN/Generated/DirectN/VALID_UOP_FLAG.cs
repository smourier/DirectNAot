#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-valid_uop_flag
public enum VALID_UOP_FLAG
{
    UOP_FLAG_Play_Title_Or_AtTime = 1,
    UOP_FLAG_Play_Chapter = 2,
    UOP_FLAG_Play_Title = 4,
    UOP_FLAG_Stop = 8,
    UOP_FLAG_ReturnFromSubMenu = 16,
    UOP_FLAG_Play_Chapter_Or_AtTime = 32,
    UOP_FLAG_PlayPrev_Or_Replay_Chapter = 64,
    UOP_FLAG_PlayNext_Chapter = 128,
    UOP_FLAG_Play_Forwards = 256,
    UOP_FLAG_Play_Backwards = 512,
    UOP_FLAG_ShowMenu_Title = 1024,
    UOP_FLAG_ShowMenu_Root = 2048,
    UOP_FLAG_ShowMenu_SubPic = 4096,
    UOP_FLAG_ShowMenu_Audio = 8192,
    UOP_FLAG_ShowMenu_Angle = 16384,
    UOP_FLAG_ShowMenu_Chapter = 32768,
    UOP_FLAG_Resume = 65536,
    UOP_FLAG_Select_Or_Activate_Button = 131072,
    UOP_FLAG_Still_Off = 262144,
    UOP_FLAG_Pause_On = 524288,
    UOP_FLAG_Select_Audio_Stream = 1048576,
    UOP_FLAG_Select_SubPic_Stream = 2097152,
    UOP_FLAG_Select_Angle = 4194304,
    UOP_FLAG_Select_Karaoke_Audio_Presentation_Mode = 8388608,
    UOP_FLAG_Select_Video_Mode_Preference = 16777216,
}
