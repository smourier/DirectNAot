#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-tvaudiomode
public enum TVAudioMode
{
    AMTVAUDIO_MODE_MONO = 1,
    AMTVAUDIO_MODE_STEREO = 2,
    AMTVAUDIO_MODE_LANG_A = 16,
    AMTVAUDIO_MODE_LANG_B = 32,
    AMTVAUDIO_MODE_LANG_C = 64,
    AMTVAUDIO_PRESET_STEREO = 512,
    AMTVAUDIO_PRESET_LANG_A = 4096,
    AMTVAUDIO_PRESET_LANG_B = 8192,
    AMTVAUDIO_PRESET_LANG_C = 16384,
}
