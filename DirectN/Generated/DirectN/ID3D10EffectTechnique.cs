#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effecttechnique
[GeneratedComInterface, Guid("db122ce8-d1c9-4292-b237-24ed3de8b175")]
public partial interface ID3D10EffectTechnique
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3D10_TECHNIQUE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getannotationbyindex
    [PreserveSig]
    ID3D10EffectVariable GetAnnotationByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getannotationbyname
    [PreserveSig]
    ID3D10EffectVariable GetAnnotationByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getpassbyindex
    [PreserveSig]
    ID3D10EffectPass GetPassByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getpassbyname
    [PreserveSig]
    ID3D10EffectPass GetPassByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-computestateblockmask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeStateBlockMask(out D3D10_STATE_BLOCK_MASK pStateBlockMask);
}
