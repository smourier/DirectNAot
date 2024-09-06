#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositioncompositeeffect
[GeneratedComInterface, Guid("576616c0-a231-494d-a38d-00fd5ec4db46")]
public partial interface IDCompositionCompositeEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncompositeeffect-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(D2D1_COMPOSITE_MODE mode);
}
