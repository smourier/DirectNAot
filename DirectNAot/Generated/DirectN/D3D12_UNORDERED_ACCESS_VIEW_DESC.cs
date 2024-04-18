namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_unordered_access_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_BUFFER_UAV Buffer;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_UAV Texture1D;
        
        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_UAV Texture1DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_UAV Texture2D;
        
        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_UAV Texture2DArray;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_UAV Texture2DMS;
        
        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_UAV Texture2DMSArray;
        
        [FieldOffset(0)]
        public D3D12_TEX3D_UAV Texture3D;
    }
    
    public DXGI_FORMAT Format;
    public D3D12_UAV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
