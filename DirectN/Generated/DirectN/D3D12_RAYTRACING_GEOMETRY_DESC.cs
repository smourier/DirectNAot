﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_geometry_desc
public partial struct D3D12_RAYTRACING_GEOMETRY_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles;
        
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs;
    }
    
    public D3D12_RAYTRACING_GEOMETRY_TYPE Type;
    public D3D12_RAYTRACING_GEOMETRY_FLAGS Flags;
    public _Anonymous_e__Union Anonymous;
}
