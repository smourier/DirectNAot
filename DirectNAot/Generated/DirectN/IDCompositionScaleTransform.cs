namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionscaletransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("71fde914-40ef-45ef-bd51-68b037c339f9")]
public partial interface IDCompositionScaleTransform : IDCompositionTransform
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setscalex(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetScaleX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setscalex(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetScaleX(float scaleX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setscaley(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetScaleY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setscaley(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetScaleY(float scaleY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterX(float centerX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionscaletransform-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterY(float centerY);
}
