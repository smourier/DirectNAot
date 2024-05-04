#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavdecaudiodualmonorepromode
public enum eAVDecAudioDualMonoReproMode
{
    eAVDecAudioDualMonoReproMode_STEREO = 0,
    eAVDecAudioDualMonoReproMode_LEFT_MONO = 1,
    eAVDecAudioDualMonoReproMode_RIGHT_MONO = 2,
    eAVDecAudioDualMonoReproMode_MIX_MONO = 3,
}
