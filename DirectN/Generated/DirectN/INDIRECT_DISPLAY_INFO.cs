#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct INDIRECT_DISPLAY_INFO
{
    public LUID DisplayAdapterLuid;
    public uint Flags;
    public uint NumMonitors;
    public uint DisplayAdapterTargetBase;
}
