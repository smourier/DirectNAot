#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT
{
    public InlineArraySystemChar_128 szAdapterFamily;
    public ulong MinimumABISupportVersion;
    public ulong MaximumABISupportVersion;
    public D3D12_VERSION_NUMBER CompilerVersion;
    public D3D12_VERSION_NUMBER ApplicationProfileVersion;
}
