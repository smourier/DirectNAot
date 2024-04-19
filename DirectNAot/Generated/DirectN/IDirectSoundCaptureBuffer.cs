namespace DirectN;

[GeneratedComInterface, Guid("b0210782-89cd-11d0-af08-00a0c925cd16")]
public partial interface IDirectSoundCaptureBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DSCBCAPS pDSCBCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(nint/* nint */ pdwCapturePosition, nint/* nint */ pdwReadPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(nint/* nint */ pwfxFormat, uint dwSizeAllocated, nint/* nint */ pdwSizeWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IDirectSoundCapture pDirectSoundCapture, in DSCBUFFERDESC pcDSCBufferDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(uint dwOffset, uint dwBytes, out nint ppvAudioPtr1, out uint pdwAudioBytes1, nint/* nint */ ppvAudioPtr2, nint/* nint */ pdwAudioBytes2, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock(nint pvAudioPtr1, uint dwAudioBytes1, nint/* nint */ pvAudioPtr2, uint dwAudioBytes2);
}
