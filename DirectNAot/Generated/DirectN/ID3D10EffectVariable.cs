namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectvariable
[GeneratedComInterface, Guid("ae897105-00e6-45bf-bb8e-281dd6db8e1b")]
public partial interface ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-gettype
    [PreserveSig]
    ID3D10EffectType GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D10_EFFECT_VARIABLE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyindex
    [PreserveSig]
    ID3D10EffectVariable GetAnnotationByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyname
    [PreserveSig]
    ID3D10EffectVariable GetAnnotationByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyindex
    [PreserveSig]
    ID3D10EffectVariable GetMemberByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyname
    [PreserveSig]
    ID3D10EffectVariable GetMemberByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbysemantic
    [PreserveSig]
    ID3D10EffectVariable GetMemberBySemantic(PSTR Semantic);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getelement
    [PreserveSig]
    ID3D10EffectVariable GetElement(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getparentconstantbuffer
    [PreserveSig]
    ID3D10EffectConstantBuffer GetParentConstantBuffer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asscalar
    [PreserveSig]
    ID3D10EffectScalarVariable AsScalar();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asvector
    [PreserveSig]
    ID3D10EffectVectorVariable AsVector();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asmatrix
    [PreserveSig]
    ID3D10EffectMatrixVariable AsMatrix();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asstring
    [PreserveSig]
    ID3D10EffectStringVariable AsString();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshaderresource
    [PreserveSig]
    ID3D10EffectShaderResourceVariable AsShaderResource();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrendertargetview
    [PreserveSig]
    ID3D10EffectRenderTargetViewVariable AsRenderTargetView();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencilview
    [PreserveSig]
    ID3D10EffectDepthStencilViewVariable AsDepthStencilView();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asconstantbuffer
    [PreserveSig]
    ID3D10EffectConstantBuffer AsConstantBuffer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshader
    [PreserveSig]
    ID3D10EffectShaderVariable AsShader();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asblend
    [PreserveSig]
    ID3D10EffectBlendVariable AsBlend();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencil
    [PreserveSig]
    ID3D10EffectDepthStencilVariable AsDepthStencil();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrasterizer
    [PreserveSig]
    ID3D10EffectRasterizerVariable AsRasterizer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-assampler
    [PreserveSig]
    ID3D10EffectSamplerVariable AsSampler();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-setrawvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRawValue(nint pData, uint Offset, uint ByteCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getrawvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawValue(nint pData, uint Offset, uint ByteCount);
}
