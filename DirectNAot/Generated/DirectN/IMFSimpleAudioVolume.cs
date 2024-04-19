namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsimpleaudiovolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("089edf13-cf71-4338-8d13-9e569dbdc319")]
public partial interface IMFSimpleAudioVolume
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsimpleaudiovolume-setmastervolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterVolume(float fLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsimpleaudiovolume-getmastervolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterVolume(out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsimpleaudiovolume-setmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMute([MarshalAs(UnmanagedType.U4)] bool bMute);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsimpleaudiovolume-getmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMute([MarshalAs(UnmanagedType.U4)] out bool pbMute);
}
