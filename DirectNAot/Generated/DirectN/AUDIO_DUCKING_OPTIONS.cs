#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ne-audioclient-audio_ducking_options
[Flags]
public enum AUDIO_DUCKING_OPTIONS
{
    AUDIO_DUCKING_OPTIONS_DEFAULT = 0,
    AUDIO_DUCKING_OPTIONS_DO_NOT_DUCK_OTHER_STREAMS = 1,
}
