namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11device3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("a05c8c37-d2c6-4732-b3a0-9ce0b0dc9ae6")]
public partial interface ID3D11Device3 : ID3D11Device2
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createtexture2d1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture2D1(in D3D11_TEXTURE2D_DESC1 pDesc1, nint /* optional D3D11_SUBRESOURCE_DATA */ pInitialData, nint /* optional ID3D11Texture2D1 */ ppTexture2D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createtexture3d1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture3D1(in D3D11_TEXTURE3D_DESC1 pDesc1, nint /* optional D3D11_SUBRESOURCE_DATA */ pInitialData, nint /* optional ID3D11Texture3D1 */ ppTexture3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createrasterizerstate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizerState2(in D3D11_RASTERIZER_DESC2 pRasterizerDesc, nint /* optional ID3D11RasterizerState2 */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createshaderresourceview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderResourceView1(ID3D11Resource pResource, nint /* optional D3D11_SHADER_RESOURCE_VIEW_DESC1 */ pDesc1, nint /* optional ID3D11ShaderResourceView1 */ ppSRView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createunorderedaccessview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateUnorderedAccessView1(ID3D11Resource pResource, nint /* optional D3D11_UNORDERED_ACCESS_VIEW_DESC1 */ pDesc1, nint /* optional ID3D11UnorderedAccessView1 */ ppUAView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createrendertargetview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderTargetView1(ID3D11Resource pResource, nint /* optional D3D11_RENDER_TARGET_VIEW_DESC1 */ pDesc1, nint /* optional ID3D11RenderTargetView1 */ ppRTView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createquery1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQuery1(in D3D11_QUERY_DESC1 pQueryDesc1, nint /* optional ID3D11Query1 */ ppQuery1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-getimmediatecontext3
    [PreserveSig]
    void GetImmediateContext3(out ID3D11DeviceContext3 ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createdeferredcontext3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeferredContext3(uint ContextFlags, nint /* optional ID3D11DeviceContext3 */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-writetosubresource
    [PreserveSig]
    void WriteToSubresource(ID3D11Resource pDstResource, uint DstSubresource, nint /* optional D3D11_BOX */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-readfromsubresource
    [PreserveSig]
    void ReadFromSubresource(nint pDstData, uint DstRowPitch, uint DstDepthPitch, ID3D11Resource pSrcResource, uint SrcSubresource, nint /* optional D3D11_BOX */ pSrcBox);
}
