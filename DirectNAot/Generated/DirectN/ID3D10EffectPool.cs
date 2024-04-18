namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectpool
[GeneratedComInterface, Guid("9537ab04-3250-412e-8213-fcd2f8677933")]
public partial interface ID3D10EffectPool
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectpool-aseffect
    [PreserveSig]
    public ID3D10Effect AsEffect();
}
