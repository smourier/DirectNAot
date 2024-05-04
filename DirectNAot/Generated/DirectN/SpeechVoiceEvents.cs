#nullable enable
namespace DirectN;

public enum SpeechVoiceEvents
{
    SVEStartInputStream = 2,
    SVEEndInputStream = 4,
    SVEVoiceChange = 8,
    SVEBookmark = 16,
    SVEWordBoundary = 32,
    SVEPhoneme = 64,
    SVESentenceBoundary = 128,
    SVEViseme = 256,
    SVEAudioLevel = 512,
    SVEPrivate = 32768,
    SVEAllEvents = 33790,
}
