#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ns-d3d11_3-d3d11_unordered_access_view_desc1
public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_BUFFER_UAV Buffer;
        
        [FieldOffset(0)]
        public D3D11_TEX1D_UAV Texture1D;
        
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_UAV1 Texture2D;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_UAV1 Texture2DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX3D_UAV Texture3D;
    }
    
    public DXGI_FORMAT Format;
    public D3D11_UAV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
