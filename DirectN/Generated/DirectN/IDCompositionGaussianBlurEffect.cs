#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiongaussianblureffect
[GeneratedComInterface, Guid("45d4d0b7-1bd4-454e-8894-2bfa68443033")]
public partial interface IDCompositionGaussianBlurEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiongaussianblureffect-setstandarddeviation(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStandardDeviation(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiongaussianblureffect-setstandarddeviation(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStandardDeviation(float amount);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiongaussianblureffect-setbordermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderMode(D2D1_BORDER_MODE mode);
}
