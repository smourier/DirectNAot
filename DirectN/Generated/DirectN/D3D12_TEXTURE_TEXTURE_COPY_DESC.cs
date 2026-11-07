#nullable enable
namespace DirectN;

public partial struct D3D12_TEXTURE_TEXTURE_COPY_DESC
{
    public nint pDest;
    public uint DestSubresourceIndex;
    public nint pSource;
    public uint SourceSubresourceIndex;
}
