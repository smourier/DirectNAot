#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_target_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_TARGET_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_BUFFER_RTV Buffer;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_RTV Texture1D;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_RTV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_RTV Texture2D;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_RTV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_RTV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_RTV Texture2DMSArray;
        
        [FieldOffset(0)]
        public D3D12_TEX3D_RTV Texture3D;
    }
    
    public DXGI_FORMAT Format;
    public D3D12_RTV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
