#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrimagecompositor9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4a5c89eb-df51-4654-ac2a-e48e02bbabf6")]
public partial interface IVMRImageCompositor9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagecompositor9-initcompositiondevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitCompositionDevice(nint pD3DDevice);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagecompositor9-termcompositiondevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TermCompositionDevice(nint pD3DDevice);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagecompositor9-setstreammediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamMediaType(uint dwStrmID, in AM_MEDIA_TYPE pmt, [MarshalAs(UnmanagedType.U4)] bool fTexture);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagecompositor9-compositeimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompositeImage(nint pD3DDevice, IDirect3DSurface9 pddsRenderTarget, in AM_MEDIA_TYPE pmtRenderTarget, long rtStart, long rtEnd, uint dwClrBkGnd, in VMR9VideoStreamInfo pVideoStreamInfo, uint cStreams);
}
