namespace DirectN;

public enum SpeechTokenContext : uint
{
    STCInprocServer = 1,
    STCInprocHandler = 2,
    STCLocalServer = 4,
    STCRemoteServer = 16,
    STCAll = 23,
}
