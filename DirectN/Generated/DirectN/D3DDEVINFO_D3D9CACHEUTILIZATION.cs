#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3d9cacheutilization
public partial struct D3DDEVINFO_D3D9CACHEUTILIZATION
{
    public float TextureCacheHitRate;
    public float PostTransformVertexCacheHitRate;
}
