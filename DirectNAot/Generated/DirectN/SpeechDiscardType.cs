namespace DirectN;

public enum SpeechDiscardType
{
    SDTProperty = 1,
    SDTReplacement = 2,
    SDTRule = 4,
    SDTDisplayText = 8,
    SDTLexicalForm = 16,
    SDTPronunciation = 32,
    SDTAudio = 64,
    SDTAlternates = 128,
    SDTAll = 255,
}
