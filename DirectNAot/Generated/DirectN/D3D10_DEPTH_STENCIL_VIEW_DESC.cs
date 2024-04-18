namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_depth_stencil_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_DEPTH_STENCIL_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D10_TEX1D_DSV Texture1D;
        
        [FieldOffset(0)]
        public D3D10_TEX1D_ARRAY_DSV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D10_TEX2D_DSV Texture2D;
        
        [FieldOffset(0)]
        public D3D10_TEX2D_ARRAY_DSV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D10_TEX2DMS_DSV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D10_TEX2DMS_ARRAY_DSV Texture2DMSArray;
    }
    
    public DXGI_FORMAT Format;
    public D3D10_DSV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
