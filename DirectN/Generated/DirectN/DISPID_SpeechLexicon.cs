#nullable enable
namespace DirectN;

public enum DISPID_SpeechLexicon
{
    DISPID_SLGenerationId = 1,
    DISPID_SLGetWords = 2,
    DISPID_SLAddPronunciation = 3,
    DISPID_SLAddPronunciationByPhoneIds = 4,
    DISPID_SLRemovePronunciation = 5,
    DISPID_SLRemovePronunciationByPhoneIds = 6,
    DISPID_SLGetPronunciations = 7,
    DISPID_SLGetGenerationChange = 8,
}
