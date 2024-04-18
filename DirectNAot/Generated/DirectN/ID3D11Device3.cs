namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11device3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("a05c8c37-d2c6-4732-b3a0-9ce0b0dc9ae6")]
public partial interface ID3D11Device3 : ID3D11Device2
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createtexture2d1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTexture2D1(in D3D11_TEXTURE2D_DESC1 pDesc1, nint/* nint */ pInitialData, nint/* nint */ ppTexture2D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createtexture3d1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTexture3D1(in D3D11_TEXTURE3D_DESC1 pDesc1, nint/* nint */ pInitialData, nint/* nint */ ppTexture3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createrasterizerstate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRasterizerState2(in D3D11_RASTERIZER_DESC2 pRasterizerDesc, nint/* nint */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createshaderresourceview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateShaderResourceView1(ID3D11Resource pResource, nint/* nint */ pDesc1, nint/* nint */ ppSRView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createunorderedaccessview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateUnorderedAccessView1(ID3D11Resource pResource, nint/* nint */ pDesc1, nint/* nint */ ppUAView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createrendertargetview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRenderTargetView1(ID3D11Resource pResource, nint/* nint */ pDesc1, nint/* nint */ ppRTView1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createquery1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateQuery1(in D3D11_QUERY_DESC1 pQueryDesc1, nint/* nint */ ppQuery1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-getimmediatecontext3
    [PreserveSig]
    public void GetImmediateContext3(out ID3D11DeviceContext3 ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-createdeferredcontext3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeferredContext3(uint ContextFlags, nint/* nint */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-writetosubresource
    [PreserveSig]
    public void WriteToSubresource(ID3D11Resource pDstResource, uint DstSubresource, nint/* nint */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11device3-readfromsubresource
    [PreserveSig]
    public void ReadFromSubresource(nint pDstData, uint DstRowPitch, uint DstDepthPitch, ID3D11Resource pSrcResource, uint SrcSubresource, nint/* nint */ pSrcBox);
}
