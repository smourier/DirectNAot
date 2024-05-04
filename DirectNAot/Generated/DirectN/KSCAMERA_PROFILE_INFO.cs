#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PROFILE_INFO
{
    public Guid ProfileId;
    public uint Index;
    public uint PinCount;
    public nint Pins;
}
