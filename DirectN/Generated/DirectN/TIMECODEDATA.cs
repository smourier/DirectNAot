#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct TIMECODEDATA
{
    public TIMECODE time;
    public uint dwSMPTEflags;
    public uint dwUser;
}
