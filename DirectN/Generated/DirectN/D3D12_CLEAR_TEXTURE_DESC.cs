#nullable enable
namespace DirectN;

public partial struct D3D12_CLEAR_TEXTURE_DESC
{
    public nint pTexture;
    public uint SubresourceIndex;
    public D3D12_CLEAR_DATA ClearValue;
    public DXGI_FORMAT Format;
    public nint pRegion;
}
