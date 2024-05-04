#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECORESULTINFO
{
    public uint cbSize;
    public SPRESULTTYPE eResultType;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fHypothesis;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fProprietaryAutoPause;
    public ulong ullStreamPosStart;
    public ulong ullStreamPosEnd;
    public SPGRAMMARHANDLE hGrammar;
    public uint ulSizeEngineData;
    public nint pvEngineData;
    public nint pPhrase;
    public nint aPhraseAlts;
    public uint ulNumAlts;
}
