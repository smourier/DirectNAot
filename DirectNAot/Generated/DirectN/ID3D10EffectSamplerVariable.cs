#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectsamplervariable
[GeneratedComInterface, Guid("6530d5c7-07e9-4271-a418-e7ce4bd1e480")]
public partial interface ID3D10EffectSamplerVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getsampler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampler(uint Index, out ID3D10SamplerState ppSampler);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectsamplervariable-getbackingstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingStore(uint Index, out D3D10_SAMPLER_DESC pSamplerDesc);
}
