#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_GUID_TEXTURE_LAYOUT
{
    public nint pDesc;
    public D3D12_FORMAT_SUPPORT1 Support1;
    public D3D12_FORMAT_SUPPORT2 Support2;
    public D3D12_GUID_TEXTURE_LAYOUT_TIER GuidTextureLayoutTier;
    public BOOL GuidSupported;
}
