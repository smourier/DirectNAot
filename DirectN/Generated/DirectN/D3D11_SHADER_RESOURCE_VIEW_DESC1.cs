#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ns-d3d11_3-d3d11_shader_resource_view_desc1
public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_BUFFER_SRV Buffer;
        
        [FieldOffset(0)]
        public D3D11_TEX1D_SRV Texture1D;
        
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_SRV1 Texture2D;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_SRV1 Texture2DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX2DMS_SRV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        
        [FieldOffset(0)]
        public D3D11_TEX3D_SRV Texture3D;
        
        [FieldOffset(0)]
        public D3D11_TEXCUBE_SRV TextureCube;
        
        [FieldOffset(0)]
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
        
        [FieldOffset(0)]
        public D3D11_BUFFEREX_SRV BufferEx;
    }
    
    public DXGI_FORMAT Format;
    public D3D_SRV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
