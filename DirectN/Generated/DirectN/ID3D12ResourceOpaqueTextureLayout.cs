#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a7c3f1e8-2b94-4d06-9f5a-e8d1c40b7263")]
public partial interface ID3D12ResourceOpaqueTextureLayout
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpaqueTextureRowMajorLayoutInfo(uint FirstSubresource, uint NumSubresources, nint /* optional D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO* */ pLayoutInfo);
}
