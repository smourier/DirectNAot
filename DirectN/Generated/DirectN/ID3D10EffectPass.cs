#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectpass
public partial struct ID3D10EffectPass
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-isvalid
    public readonly unsafe BOOL IsValid() =>
        ((delegate* unmanaged<ID3D10EffectPass*, BOOL>)(((void**)*((void**)VTablePtr))[0]))((ID3D10EffectPass*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_PASS_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectPass*,D3D10_PASS_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[1]))((ID3D10EffectPass*)VTablePtr, (D3D10_PASS_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getvertexshaderdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetVertexShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectPass*,D3D10_PASS_SHADER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[2]))((ID3D10EffectPass*)VTablePtr, (D3D10_PASS_SHADER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getgeometryshaderdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetGeometryShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectPass*,D3D10_PASS_SHADER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[3]))((ID3D10EffectPass*)VTablePtr, (D3D10_PASS_SHADER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getpixelshaderdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetPixelShaderDesc(ref D3D10_PASS_SHADER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectPass*,D3D10_PASS_SHADER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[4]))((ID3D10EffectPass*)VTablePtr, (D3D10_PASS_SHADER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getannotationbyindex
    public readonly unsafe nint GetAnnotationByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectPass*,uint, nint>)(((void**)*((void**)VTablePtr))[5]))((ID3D10EffectPass*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-getannotationbyname
    public readonly unsafe nint GetAnnotationByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10EffectPass*,PSTR, nint>)(((void**)*((void**)VTablePtr))[6]))((ID3D10EffectPass*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-apply
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT Apply(uint Flags) =>
        ((delegate* unmanaged<ID3D10EffectPass*,uint, HRESULT>)(((void**)*((void**)VTablePtr))[7]))((ID3D10EffectPass*)VTablePtr, Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpass-computestateblockmask
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ComputeStateBlockMask(ref D3D10_STATE_BLOCK_MASK pStateBlockMask) =>
        ((delegate* unmanaged<ID3D10EffectPass*,D3D10_STATE_BLOCK_MASK*, HRESULT>)(((void**)*((void**)VTablePtr))[8]))((ID3D10EffectPass*)VTablePtr, (D3D10_STATE_BLOCK_MASK*)Unsafe.AsPointer(ref pStateBlockMask));
}
