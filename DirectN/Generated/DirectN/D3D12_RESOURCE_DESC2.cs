#nullable enable
namespace DirectN;

public partial struct D3D12_RESOURCE_DESC2
{
    public D3D12_RESOURCE_DIMENSION Dimension;
    public ulong Alignment;
    public ulong Width;
    public uint Height;
    public ushort DepthOrArraySize;
    public ushort MipLevels;
    public DXGI_FORMAT Format;
    public DXGI_SAMPLE_DESC SampleDesc;
    public D3D12_TEXTURE_LAYOUT Layout;
    public D3D12_RESOURCE_FLAGS Flags;
    public D3D12_MIP_REGION SamplerFeedbackMipRegion;
    public Guid LayoutGuid;
}
