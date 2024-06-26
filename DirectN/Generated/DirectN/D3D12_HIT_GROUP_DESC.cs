﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_hit_group_desc
public partial struct D3D12_HIT_GROUP_DESC
{
    public PWSTR HitGroupExport;
    public D3D12_HIT_GROUP_TYPE Type;
    public PWSTR AnyHitShaderImport;
    public PWSTR ClosestHitShaderImport;
    public PWSTR IntersectionShaderImport;
}
