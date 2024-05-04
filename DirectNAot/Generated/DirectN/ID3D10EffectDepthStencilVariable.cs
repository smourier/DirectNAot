#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectdepthstencilvariable
[GeneratedComInterface, Guid("af482368-330a-46a5-9a5c-01c71af24c8d")]
public partial interface ID3D10EffectDepthStencilVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilvariable-getdepthstencilstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDepthStencilState(uint Index, out ID3D10DepthStencilState ppDepthStencilState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilvariable-getbackingstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingStore(uint Index, out D3D10_DEPTH_STENCIL_DESC pDepthStencilDesc);
}
