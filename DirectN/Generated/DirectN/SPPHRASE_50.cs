#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASE_50
{
    public uint cbSize;
    public ushort LangID;
    public ushort wHomophoneGroupId;
    public ulong ullGrammarID;
    public ulong ftStartTime;
    public ulong ullAudioStreamPosition;
    public uint ulAudioSizeBytes;
    public uint ulRetainedSizeBytes;
    public uint ulAudioSizeTime;
    public SPPHRASERULE Rule;
    public nint pProperties;
    public nint pElements;
    public uint cReplacements;
    public nint pReplacements;
    public Guid SREngineID;
    public uint ulSREnginePrivateDataSize;
    public nint pSREnginePrivateData;
}
