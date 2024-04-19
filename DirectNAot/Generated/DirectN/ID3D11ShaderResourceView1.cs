namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11shaderresourceview1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("91308b87-9040-411d-8c67-c39253ce3802")]
public partial interface ID3D11ShaderResourceView1 : ID3D11ShaderResourceView
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11shaderresourceview1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_SHADER_RESOURCE_VIEW_DESC1 pDesc1);
}
