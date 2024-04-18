﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3d9cacheutilization
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_D3D9CACHEUTILIZATION
{
    public float TextureCacheHitRate;
    public float PostTransformVertexCacheHitRate;
}
