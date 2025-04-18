#nullable enable
namespace DirectN;

public partial struct SPPARSEINFO
{
    public uint cbSize;
    public SPRULEHANDLE hRule;
    public ulong ullAudioStreamPosition;
    public uint ulAudioSize;
    public uint cTransitions;
    public nint pPath;
    public Guid SREngineID;
    public uint ulSREnginePrivateDataSize;
    public nint pSREnginePrivateData;
    public BOOL fHypothesis;
}
