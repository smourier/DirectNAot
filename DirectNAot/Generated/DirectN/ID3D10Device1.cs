namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/nn-d3d10_1-id3d10device1
[GeneratedComInterface, Guid("9b7e4c8f-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Device1 : ID3D10Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-id3d10device1-createshaderresourceview1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderResourceView1(ID3D10Resource pResource, nint/* nint */ pDesc, nint/* nint */ ppSRView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-id3d10device1-createblendstate1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlendState1(in D3D10_BLEND_DESC1 pBlendStateDesc, nint/* nint */ ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-id3d10device1-getfeaturelevel
    [PreserveSig]
    D3D10_FEATURE_LEVEL1 GetFeatureLevel();
}
