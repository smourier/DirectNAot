#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/ns-d3d10_1-d3d10_shader_resource_view_desc1
public partial struct D3D10_SHADER_RESOURCE_VIEW_DESC1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D10_BUFFER_SRV Buffer;
        
        [FieldOffset(0)]
        public D3D10_TEX1D_SRV Texture1D;
        
        [FieldOffset(0)]
        public D3D10_TEX1D_ARRAY_SRV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D10_TEX2D_SRV Texture2D;
        
        [FieldOffset(0)]
        public D3D10_TEX2D_ARRAY_SRV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D10_TEX2DMS_SRV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D10_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        
        [FieldOffset(0)]
        public D3D10_TEX3D_SRV Texture3D;
        
        [FieldOffset(0)]
        public D3D10_TEXCUBE_SRV TextureCube;
        
        [FieldOffset(0)]
        public D3D10_TEXCUBE_ARRAY_SRV1 TextureCubeArray;
    }
    
    public DXGI_FORMAT Format;
    public D3D_SRV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
