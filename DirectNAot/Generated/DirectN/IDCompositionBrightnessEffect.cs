namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionbrightnesseffect
[GeneratedComInterface, Guid("6027496e-cb3a-49ab-934f-d798da4f7da6")]
public partial interface IDCompositionBrightnessEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setwhitepoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePoint(in D2D_VECTOR_2F whitePoint);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setblackpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlackPoint(in D2D_VECTOR_2F blackPoint);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setwhitepointx(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setwhitepointx(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointX(float whitePointX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setwhitepointy(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setwhitepointy(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointY(float whitePointY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setblackpointx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlackPointX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setblackpointx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlackPointX(float blackPointX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setblackpointy(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlackPointY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionbrightnesseffect-setblackpointy(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlackPointY(float blackPointY);
}
