#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionblendeffect
[GeneratedComInterface, Guid("33ecdc0a-578a-4a11-9c14-0cb90517f9c5")]
public partial interface IDCompositionBlendEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionblendeffect-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(D2D1_BLEND_MODE mode);
}
