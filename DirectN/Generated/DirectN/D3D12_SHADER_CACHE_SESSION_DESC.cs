#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_shader_cache_session_desc
public partial struct D3D12_SHADER_CACHE_SESSION_DESC
{
    public Guid Identifier;
    public D3D12_SHADER_CACHE_MODE Mode;
    public D3D12_SHADER_CACHE_FLAGS Flags;
    public uint MaximumInMemoryCacheSizeBytes;
    public uint MaximumInMemoryCacheEntries;
    public uint MaximumValueFileSizeBytes;
    public ulong Version;
}
