#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ne-wmcodecdsp-aec_system_mode
public enum AEC_SYSTEM_MODE
{
    SINGLE_CHANNEL_AEC = 0,
    ADAPTIVE_ARRAY_ONLY = 1,
    OPTIBEAM_ARRAY_ONLY = 2,
    ADAPTIVE_ARRAY_AND_AEC = 3,
    OPTIBEAM_ARRAY_AND_AEC = 4,
    SINGLE_CHANNEL_NSAGC = 5,
    MODE_NOT_SET = 6,
}
