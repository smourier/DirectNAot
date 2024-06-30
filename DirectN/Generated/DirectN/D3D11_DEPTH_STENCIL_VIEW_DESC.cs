#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_depth_stencil_view_desc
public partial struct D3D11_DEPTH_STENCIL_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_TEX1D_DSV Texture1D;
        
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_DSV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_DSV Texture2D;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_DSV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D11_TEX2DMS_DSV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
    }
    
    public DXGI_FORMAT Format;
    public D3D11_DSV_DIMENSION ViewDimension;
    public uint Flags;
    public _Anonymous_e__Union Anonymous;
}
