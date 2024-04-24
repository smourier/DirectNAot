namespace DirectN;

[GeneratedComInterface, Guid("279afa83-4981-11ce-a521-0020af0be560")]
public partial interface IDirectSound
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSoundBuffer(in DSBUFFERDESC pcDSBufferDesc, out IDirectSoundBuffer ppDSBuffer, nint pUnkOuter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DSCAPS pDSCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DuplicateSoundBuffer(IDirectSoundBuffer pDSBufferOriginal, out IDirectSoundBuffer ppDSBufferDuplicate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCooperativeLevel(HWND hwnd, uint dwLevel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compact();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpeakerConfig(out uint pdwSpeakerConfig);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpeakerConfig(uint dwSpeakerConfig);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint /* optional Guid* */ pcGuidDevice);
}
