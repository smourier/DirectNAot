#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_PACKETVREGISTER
{
    public nint CompletedPacketCount;
    public nint CompletedPacketQPC;
    public nint CompletedPacketHash;
}
