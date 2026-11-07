#nullable enable
namespace DirectN;

public partial struct D3D12_TEXTURE_COPY_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_TEXTURE_TEXTURE_COPY_DESC TextureTextureCopy;
        
        [FieldOffset(0)]
        public D3D12_BUFFER_TEXTURE_COPY_DESC BufferTextureCopy;
    }
    
    public D3D12_TEXTURE_COPY_DESC_TYPE Type;
    public uint NumRegions;
    public nint pCopyRegions;
    public _Anonymous_e__Union Anonymous;
}
