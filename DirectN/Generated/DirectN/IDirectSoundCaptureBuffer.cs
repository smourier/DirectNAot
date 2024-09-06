#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b0210782-89cd-11d0-af08-00a0c925cd16")]
public partial interface IDirectSoundCaptureBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DSCBCAPS pDSCBCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(nint /* optional uint* */ pdwCapturePosition, nint /* optional uint* */ pdwReadPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(nint /* optional WAVEFORMATEX* */ pwfxFormat, uint dwSizeAllocated, nint /* optional uint* */ pdwSizeWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IDirectSoundCapture pDirectSoundCapture, in DSCBUFFERDESC pcDSCBufferDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(uint dwOffset, uint dwBytes, out nint ppvAudioPtr1, out uint pdwAudioBytes1, nint /* optional void** */ ppvAudioPtr2, nint /* optional uint* */ pdwAudioBytes2, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock(nint pvAudioPtr1, uint dwAudioBytes1, nint /* optional void* */ pvAudioPtr2, uint dwAudioBytes2);
}
