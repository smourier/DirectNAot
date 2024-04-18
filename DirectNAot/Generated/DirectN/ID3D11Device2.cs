namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/nn-d3d11_2-id3d11device2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("9d06dffa-d1e5-4d07-83a8-1bb123f2f841")]
public partial interface ID3D11Device2 : ID3D11Device1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-getimmediatecontext2
    [PreserveSig]
    public void GetImmediateContext2(out ID3D11DeviceContext2 ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-createdeferredcontext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeferredContext2(uint ContextFlags, nint/* nint */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-getresourcetiling
    [PreserveSig]
    public void GetResourceTiling(ID3D11Resource pTiledResource, nint/* nint */ pNumTilesForEntireResource, nint/* nint */ pPackedMipDesc, nint/* nint */ pStandardTileShapeForNonPackedMips, nint/* nint */ pNumSubresourceTilings, uint FirstSubresourceTilingToGet, out D3D11_SUBRESOURCE_TILING pSubresourceTilingsForNonPackedMips);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11device2-checkmultisamplequalitylevels1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckMultisampleQualityLevels1(DXGI_FORMAT Format, uint SampleCount, uint Flags, out uint pNumQualityLevels);
}
