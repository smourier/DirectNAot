namespace DirectN;

public enum SpeechPartOfSpeech
{
    SPSNotOverriden = -1,
    SPSUnknown = 0,
    SPSNoun = 4096,
    SPSVerb = 8192,
    SPSModifier = 12288,
    SPSFunction = 16384,
    SPSInterjection = 20480,
    SPSLMA = 28672,
    SPSSuppressWord = 61440,
}
