#nullable enable
namespace DirectN;

public partial struct D3D12_SHADER_CACHE_SESSION_INFO
{
    public ulong CurrentSizeBytes;
    public ulong MaximumSizeBytes;
    public ulong ReservedSizeBytes;
    public uint EntryCount;
    public ulong LifetimeEvictedEntryCount;
}
