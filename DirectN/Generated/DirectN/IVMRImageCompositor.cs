#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrimagecompositor
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7a4fb5af-479f-4074-bb40-ce6722e43c82")]
public partial interface IVMRImageCompositor
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagecompositor-initcompositiontarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitCompositionTarget(nint pD3DDevice, IDirectDrawSurface7 pddsRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagecompositor-termcompositiontarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TermCompositionTarget(nint pD3DDevice, IDirectDrawSurface7 pddsRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagecompositor-setstreammediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamMediaType(uint dwStrmID, in AM_MEDIA_TYPE pmt, BOOL fTexture);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagecompositor-compositeimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompositeImage(nint pD3DDevice, IDirectDrawSurface7 pddsRenderTarget, in AM_MEDIA_TYPE pmtRenderTarget, long rtStart, long rtEnd, uint dwClrBkGnd, in VMRVIDEOSTREAMINFO pVideoStreamInfo, uint cStreams);
}
