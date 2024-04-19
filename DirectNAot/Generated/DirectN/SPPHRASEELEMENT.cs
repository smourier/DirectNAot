namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEELEMENT
{
    public uint ulAudioTimeOffset;
    public uint ulAudioSizeTime;
    public uint ulAudioStreamOffset;
    public uint ulAudioSizeBytes;
    public uint ulRetainedStreamOffset;
    public uint ulRetainedSizeBytes;
    public PWSTR pszDisplayText;
    public PWSTR pszLexicalForm;
    public nint pszPronunciation;
    public byte bDisplayAttributes;
    public sbyte RequiredConfidence;
    public sbyte ActualConfidence;
    public byte Reserved;
    public float SREngineConfidence;
}
