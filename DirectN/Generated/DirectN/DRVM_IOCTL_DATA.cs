#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRVM_IOCTL_DATA
{
    public uint dwSize;
    public uint dwCmd;
}
