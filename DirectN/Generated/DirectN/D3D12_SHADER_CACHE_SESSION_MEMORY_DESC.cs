#nullable enable
namespace DirectN;

public partial struct D3D12_SHADER_CACHE_SESSION_MEMORY_DESC
{
    public Guid Identifier;
    public D3D12_SHADER_CACHE_FLAGS Flags;
    public uint MaximumInMemoryCacheSizeBytes;
    public uint MaximumInMemoryCacheEntries;
    public ulong Version;
}
