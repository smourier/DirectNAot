namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectpass
[GeneratedComInterface, Guid("5cfbeb89-1a06-46e0-b282-e3f9bfa36a54")]
public partial interface ID3D10EffectPass
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(ref D3D10_PASS_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getvertexshaderdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVertexShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getgeometryshaderdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGeometryShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getpixelshaderdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPixelShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getannotationbyindex
    [PreserveSig]
    public ID3D10EffectVariable GetAnnotationByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getannotationbyname
    [PreserveSig]
    public ID3D10EffectVariable GetAnnotationByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-apply
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Apply(uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-computestateblockmask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ComputeStateBlockMask(out D3D10_STATE_BLOCK_MASK pStateBlockMask);
}
