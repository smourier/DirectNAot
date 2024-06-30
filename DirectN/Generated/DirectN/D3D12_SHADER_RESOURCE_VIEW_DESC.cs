﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_shader_resource_view_desc
public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_BUFFER_SRV Buffer;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_SRV Texture1D;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_SRV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_SRV Texture2D;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_SRV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_SRV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        
        [FieldOffset(0)]
        public D3D12_TEX3D_SRV Texture3D;
        
        [FieldOffset(0)]
        public D3D12_TEXCUBE_SRV TextureCube;
        
        [FieldOffset(0)]
        public D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray;
        
        [FieldOffset(0)]
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure;
    }
    
    public DXGI_FORMAT Format;
    public D3D12_SRV_DIMENSION ViewDimension;
    public uint Shader4ComponentMapping;
    public _Anonymous_e__Union Anonymous;
}
