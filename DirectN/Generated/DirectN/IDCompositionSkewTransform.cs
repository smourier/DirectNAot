#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionskewtransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("e57aa735-dcdb-4c72-9c61-0591f58889ee")]
public partial interface IDCompositionSkewTransform : IDCompositionTransform
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setanglex(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAngleX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setanglex(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAngleX(float angleX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setangley(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAngleY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setangley(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAngleY(float angleY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCenterX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCenterX(float centerX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCenterY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionskewtransform-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCenterY(float centerY);
}
