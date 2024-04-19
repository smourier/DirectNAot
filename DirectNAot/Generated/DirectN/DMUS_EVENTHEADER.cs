namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_EVENTHEADER
{
    public uint cbEvent;
    public uint dwChannelGroup;
    public long rtDelta;
    public uint dwFlags;
}
