namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist5
[GeneratedComInterface, Guid("55050859-4024-474c-87f5-6472eaee44ea")]
public partial interface ID3D12GraphicsCommandList5 : ID3D12GraphicsCommandList4
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist5-rssetshadingrate
    [PreserveSig]
    void RSSetShadingRate(D3D12_SHADING_RATE baseShadingRate, nint /* optional D3D12_SHADING_RATE_COMBINER* */ combiners);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist5-rssetshadingrateimage
    [PreserveSig]
    void RSSetShadingRateImage(ID3D12Resource? shadingRateImage);
}
