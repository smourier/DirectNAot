#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevice3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("0987cb06-f916-48bf-8d35-ce7641781bd9")]
public partial interface IDCompositionDevice3 : IDCompositionDevice2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-creategaussianblureffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGaussianBlurEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionGaussianBlurEffect>))] out IDCompositionGaussianBlurEffect gaussianBlurEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createbrightnesseffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBrightnessEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionBrightnessEffect>))] out IDCompositionBrightnessEffect brightnessEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createcolormatrixeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorMatrixEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionColorMatrixEffect>))] out IDCompositionColorMatrixEffect colorMatrixEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createshadoweffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShadowEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionShadowEffect>))] out IDCompositionShadowEffect shadowEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createhuerotationeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHueRotationEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionHueRotationEffect>))] out IDCompositionHueRotationEffect hueRotationEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createsaturationeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSaturationEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionSaturationEffect>))] out IDCompositionSaturationEffect saturationEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createturbulenceeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTurbulenceEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTurbulenceEffect>))] out IDCompositionTurbulenceEffect turbulenceEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createlineartransfereffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLinearTransferEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionLinearTransferEffect>))] out IDCompositionLinearTransferEffect linearTransferEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createtabletransfereffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTableTransferEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTableTransferEffect>))] out IDCompositionTableTransferEffect tableTransferEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createcompositeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompositeEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionCompositeEffect>))] out IDCompositionCompositeEffect compositeEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createblendeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlendEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionBlendEffect>))] out IDCompositionBlendEffect blendEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createarithmeticcompositeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateArithmeticCompositeEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionArithmeticCompositeEffect>))] out IDCompositionArithmeticCompositeEffect arithmeticCompositeEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevice3-createaffinetransform2deffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAffineTransform2DEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAffineTransform2DEffect>))] out IDCompositionAffineTransform2DEffect affineTransform2dEffect);
}
