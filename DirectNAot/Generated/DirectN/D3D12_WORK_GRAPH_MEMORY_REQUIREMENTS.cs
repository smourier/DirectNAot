#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS
{
    public ulong MinSizeInBytes;
    public ulong MaxSizeInBytes;
    public uint SizeGranularityInBytes;
}
