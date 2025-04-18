#nullable enable
namespace DirectN;

public partial struct SPRECORESULTINFO
{
    public uint cbSize;
    public SPRESULTTYPE eResultType;
    public BOOL fHypothesis;
    public BOOL fProprietaryAutoPause;
    public ulong ullStreamPosStart;
    public ulong ullStreamPosEnd;
    public SPGRAMMARHANDLE hGrammar;
    public uint ulSizeEngineData;
    public nint pvEngineData;
    public nint pPhrase;
    public nint aPhraseAlts;
    public uint ulNumAlts;
}
