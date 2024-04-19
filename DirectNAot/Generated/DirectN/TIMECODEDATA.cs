namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TIMECODEDATA
{
    public TIMECODE time;
    public uint dwSMPTEflags;
    public uint dwUser;
}
