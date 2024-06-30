#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_desc
public partial struct D3D12_RESOURCE_DESC
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
}
