#nullable enable
namespace DirectN;

public partial struct D3D12_CACHE_FILE_DESC
{
    public D3D12_CACHE_VALUE_TYPE_FLAGS Types;
    public ulong MaximumSizeBytes;
    public PWSTR pPath;
}
