#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSFRAMETIME
{
    public long Duration;
    public uint FrameFlags;
    public uint Reserved;
}
