namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/nn-d3d10_1-id3d10shaderresourceview1
[GeneratedComInterface, Guid("9b7e4c87-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10ShaderResourceView1 : ID3D10ShaderResourceView
{
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-id3d10shaderresourceview1-getdesc1
    [PreserveSig]
    public void GetDesc1(out D3D10_SHADER_RESOURCE_VIEW_DESC1 pDesc);
}
