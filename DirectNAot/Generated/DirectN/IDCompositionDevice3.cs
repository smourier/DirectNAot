namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("0987cb06-f916-48bf-8d35-ce7641781bd9")]
public partial interface IDCompositionDevice3 : IDCompositionDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-creategaussianblureffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGaussianBlurEffect(out IDCompositionGaussianBlurEffect gaussianBlurEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createbrightnesseffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBrightnessEffect(out IDCompositionBrightnessEffect brightnessEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createcolormatrixeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateColorMatrixEffect(out IDCompositionColorMatrixEffect colorMatrixEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createshadoweffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateShadowEffect(out IDCompositionShadowEffect shadowEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createhuerotationeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateHueRotationEffect(out IDCompositionHueRotationEffect hueRotationEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createsaturationeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSaturationEffect(out IDCompositionSaturationEffect saturationEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createturbulenceeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTurbulenceEffect(out IDCompositionTurbulenceEffect turbulenceEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createlineartransfereffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateLinearTransferEffect(out IDCompositionLinearTransferEffect linearTransferEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createtabletransfereffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateTableTransferEffect(out IDCompositionTableTransferEffect tableTransferEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createcompositeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCompositeEffect(out IDCompositionCompositeEffect compositeEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createblendeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlendEffect(out IDCompositionBlendEffect blendEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createarithmeticcompositeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateArithmeticCompositeEffect(out IDCompositionArithmeticCompositeEffect arithmeticCompositeEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createaffinetransform2deffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAffineTransform2DEffect(out IDCompositionAffineTransform2DEffect affineTransform2dEffect);
}
