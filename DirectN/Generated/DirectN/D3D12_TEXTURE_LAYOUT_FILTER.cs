#nullable enable
namespace DirectN;

public partial struct D3D12_TEXTURE_LAYOUT_FILTER
{
    public D3D12_RESOURCE_DESC2 Desc;
    public D3D12_FORMAT_SUPPORT1 Support1;
    public D3D12_FORMAT_SUPPORT2 Support2;
    public D3D12_TEXTURE_LAYOUT_FILTER_FLAGS Flags;
}
