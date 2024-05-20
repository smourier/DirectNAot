#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-isimpleaudiovolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("87ce5498-68d6-44e5-9215-6da47ef883d8")]
public partial interface ISimpleAudioVolume
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-isimpleaudiovolume-setmastervolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterVolume(float fLevel, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-isimpleaudiovolume-getmastervolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterVolume(out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-isimpleaudiovolume-setmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMute([MarshalAs(UnmanagedType.U4)] bool bMute, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-isimpleaudiovolume-getmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMute([MarshalAs(UnmanagedType.U4)] out bool pbMute);
}
