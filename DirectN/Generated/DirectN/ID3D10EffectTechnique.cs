#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effecttechnique
public partial struct ID3D10EffectTechnique
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-isvalid
    public readonly unsafe BOOL IsValid() =>
        ((delegate* unmanaged<ID3D10EffectTechnique*, BOOL>)(((void**)*((void**)VTablePtr))[0]))((ID3D10EffectTechnique*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_TECHNIQUE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,D3D10_TECHNIQUE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[1]))((ID3D10EffectTechnique*)VTablePtr, (D3D10_TECHNIQUE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getannotationbyindex
    public readonly unsafe nint GetAnnotationByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,uint, nint>)(((void**)*((void**)VTablePtr))[2]))((ID3D10EffectTechnique*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getannotationbyname
    public readonly unsafe nint GetAnnotationByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,PSTR, nint>)(((void**)*((void**)VTablePtr))[3]))((ID3D10EffectTechnique*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getpassbyindex
    public readonly unsafe nint GetPassByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,uint, nint>)(((void**)*((void**)VTablePtr))[4]))((ID3D10EffectTechnique*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-getpassbyname
    public readonly unsafe nint GetPassByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,PSTR, nint>)(((void**)*((void**)VTablePtr))[5]))((ID3D10EffectTechnique*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttechnique-computestateblockmask
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ComputeStateBlockMask(ref D3D10_STATE_BLOCK_MASK pStateBlockMask) =>
        ((delegate* unmanaged<ID3D10EffectTechnique*,D3D10_STATE_BLOCK_MASK*, HRESULT>)(((void**)*((void**)VTablePtr))[6]))((ID3D10EffectTechnique*)VTablePtr, (D3D10_STATE_BLOCK_MASK*)Unsafe.AsPointer(ref pStateBlockMask));
}
