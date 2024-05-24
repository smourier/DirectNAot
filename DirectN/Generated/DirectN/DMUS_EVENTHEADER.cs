#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct DMUS_EVENTHEADER
{
    public uint cbEvent;
    public uint dwChannelGroup;
    public long rtDelta;
    public uint dwFlags;
}
