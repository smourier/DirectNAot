#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b0210781-89cd-11d0-af08-00a0c925cd16")]
public partial interface IDirectSoundCapture
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCaptureBuffer(in DSCBUFFERDESC pcDSCBufferDesc, out IDirectSoundCaptureBuffer ppDSCBuffer, nint pUnkOuter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DSCCAPS pDSCCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint /* optional Guid* */ pcGuidDevice);
}
