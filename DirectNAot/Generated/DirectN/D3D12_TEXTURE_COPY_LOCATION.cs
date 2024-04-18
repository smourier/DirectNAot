namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_texture_copy_location
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEXTURE_COPY_LOCATION
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint;
        
        [FieldOffset(0)]
        public uint SubresourceIndex;
    }
    
    public nint pResource;
    public D3D12_TEXTURE_COPY_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
