#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/nn-d3d11_2-id3d11device2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("9d06dffa-d1e5-4d07-83a8-1bb123f2f841")]
public partial interface ID3D11Device2 : ID3D11Device1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-getimmediatecontext2
    [PreserveSig]
    void GetImmediateContext2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext2>))] out ID3D11DeviceContext2 ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-createdeferredcontext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeferredContext2(uint ContextFlags, nint /* optional ID3D11DeviceContext2* */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-getresourcetiling
    [PreserveSig]
    void GetResourceTiling(ID3D11Resource pTiledResource, nint /* optional uint* */ pNumTilesForEntireResource, nint /* optional D3D11_PACKED_MIP_DESC* */ pPackedMipDesc, nint /* optional D3D11_TILE_SHAPE* */ pStandardTileShapeForNonPackedMips, nint /* optional uint* */ pNumSubresourceTilings, uint FirstSubresourceTilingToGet, [MarshalUsing(CountElementName = nameof(pNumSubresourceTilings))] out D3D11_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-checkmultisamplequalitylevels1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckMultisampleQualityLevels1(DXGI_FORMAT Format, uint SampleCount, uint Flags, out uint pNumQualityLevels);
}
