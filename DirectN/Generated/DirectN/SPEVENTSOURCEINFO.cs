#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPEVENTSOURCEINFO
{
    public ulong ullEventInterest;
    public ulong ullQueuedInterest;
    public uint ulCount;
}
