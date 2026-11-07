#nullable enable
namespace DirectN;

public partial struct D3D12_BUFFER_TEXTURE_COPY_DESC
{
    public nint pBuffer;
    public nint pTexture;
    public uint SubresourceIndex;
    public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint;
}
