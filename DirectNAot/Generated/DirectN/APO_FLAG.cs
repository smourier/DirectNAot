namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ne-audioenginebaseapo-apo_flag
public enum APO_FLAG
{
    APO_FLAG_NONE = 0,
    APO_FLAG_INPLACE = 1,
    APO_FLAG_SAMPLESPERFRAME_MUST_MATCH = 2,
    APO_FLAG_FRAMESPERSECOND_MUST_MATCH = 4,
    APO_FLAG_BITSPERSAMPLE_MUST_MATCH = 8,
    APO_FLAG_MIXER = 16,
    APO_FLAG_DEFAULT = 14,
}
