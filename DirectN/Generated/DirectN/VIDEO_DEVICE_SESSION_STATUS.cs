#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_DEVICE_SESSION_STATUS
{
    public uint bEnable;
    public uint bSuccess;
}
