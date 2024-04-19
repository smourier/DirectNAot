namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVITCDLINDEX_ENTRY
{
    public uint dwTick;
    public TIMECODE time;
    public uint dwSMPTEflags;
    public uint dwUser;
    public InlineArraySByte12 szReelId;
}
