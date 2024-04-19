namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ne-audioclient-audclnt_streamoptions
public enum AUDCLNT_STREAMOPTIONS
{
    AUDCLNT_STREAMOPTIONS_NONE = 0,
    AUDCLNT_STREAMOPTIONS_RAW = 1,
    AUDCLNT_STREAMOPTIONS_MATCH_FORMAT = 2,
    AUDCLNT_STREAMOPTIONS_AMBISONICS = 4,
}
