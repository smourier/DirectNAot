#nullable enable
namespace DirectN;

public partial struct INDIRECT_DISPLAY_INFO
{
    public LUID DisplayAdapterLuid;
    public uint Flags;
    public uint NumMonitors;
    public uint DisplayAdapterTargetBase;
}
