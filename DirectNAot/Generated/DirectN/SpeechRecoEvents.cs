namespace DirectN;

public enum SpeechRecoEvents
{
    SREStreamEnd = 1,
    SRESoundStart = 2,
    SRESoundEnd = 4,
    SREPhraseStart = 8,
    SRERecognition = 16,
    SREHypothesis = 32,
    SREBookmark = 64,
    SREPropertyNumChange = 128,
    SREPropertyStringChange = 256,
    SREFalseRecognition = 512,
    SREInterference = 1024,
    SRERequestUI = 2048,
    SREStateChange = 4096,
    SREAdaptation = 8192,
    SREStreamStart = 16384,
    SRERecoOtherContext = 32768,
    SREAudioLevel = 65536,
    SREPrivate = 262144,
    SREAllEvents = 393215,
}
