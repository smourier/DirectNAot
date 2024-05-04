#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_POWER_MANAGEMENT
{
    public uint Length;
    public uint DPMSVersion;
    public uint PowerState;
}
