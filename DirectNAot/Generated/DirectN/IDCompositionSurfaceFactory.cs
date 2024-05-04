#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionsurfacefactory
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e334bc12-3937-4e02-85eb-fcf4eb30d2c8")]
public partial interface IDCompositionSurfaceFactory
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurfacefactory-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionSurface surface);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurfacefactory-createvirtualsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, out IDCompositionVirtualSurface virtualSurface);
}
