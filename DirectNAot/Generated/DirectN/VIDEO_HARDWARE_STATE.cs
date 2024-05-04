#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_HARDWARE_STATE
{
    public nint StateHeader;
    public uint StateLength;
}
