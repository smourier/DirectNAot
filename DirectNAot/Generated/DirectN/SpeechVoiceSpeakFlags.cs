#nullable enable
namespace DirectN;

public enum SpeechVoiceSpeakFlags
{
    SVSFDefault = 0,
    SVSFlagsAsync = 1,
    SVSFPurgeBeforeSpeak = 2,
    SVSFIsFilename = 4,
    SVSFIsXML = 8,
    SVSFIsNotXML = 16,
    SVSFPersistXML = 32,
    SVSFNLPSpeakPunc = 64,
    SVSFParseSapi = 128,
    SVSFParseSsml = 256,
    SVSFParseAutodetect = 0,
    SVSFNLPMask = 64,
    SVSFParseMask = 384,
    SVSFVoiceMask = 511,
    SVSFUnusedFlags = -512,
}
