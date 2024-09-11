#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiontranslatetransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("06791122-c6f0-417d-8323-269e987f5954")]
public partial interface IDCompositionTranslateTransform : IDCompositionTransform
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontranslatetransform-setoffsetx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontranslatetransform-setoffsetx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetX(float offsetX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontranslatetransform-setoffsety(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontranslatetransform-setoffsety(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetY(float offsetY);
}
