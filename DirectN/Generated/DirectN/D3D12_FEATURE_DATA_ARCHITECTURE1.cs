#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_architecture1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_ARCHITECTURE1
{
    public uint NodeIndex;
    public BOOL TileBasedRenderer;
    public BOOL UMA;
    public BOOL CacheCoherentUMA;
    public BOOL IsolatedMMU;
}
