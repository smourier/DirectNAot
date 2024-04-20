namespace DirectN;

[GeneratedComInterface, Guid("279afa85-4981-11ce-a521-0020af0be560")]
public partial interface IDirectSoundBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DSBCAPS pDSBufferCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(nint /* optional uint */ pdwCurrentPlayCursor, nint /* optional uint */ pdwCurrentWriteCursor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(nint /* optional WAVEFORMATEX */ pwfxFormat, uint dwSizeAllocated, nint /* optional uint */ pdwSizeWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolume(out int plVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPan(out int plPan);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrequency(out uint pdwFrequency);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IDirectSound pDirectSound, in DSBUFFERDESC pcDSBufferDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(uint dwOffset, uint dwBytes, out nint ppvAudioPtr1, out uint pdwAudioBytes1, nint /* optional void */ ppvAudioPtr2, nint /* optional uint */ pdwAudioBytes2, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Play(uint dwReserved1, uint dwPriority, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPosition(uint dwNewPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in WAVEFORMATEX pcfxFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolume(int lVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPan(int lPan);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFrequency(uint dwFrequency);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock(nint pvAudioPtr1, uint dwAudioBytes1, nint /* optional void */ pvAudioPtr2, uint dwAudioBytes2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Restore();
}
