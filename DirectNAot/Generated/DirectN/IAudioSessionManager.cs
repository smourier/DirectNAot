namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessionmanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bfa971f1-4d5e-40bb-935e-967039bfbee4")]
public partial interface IAudioSessionManager
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager-getaudiosessioncontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioSessionControl(nint /* optional Guid */ AudioSessionGuid, uint StreamFlags, out IAudioSessionControl SessionControl);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager-getsimpleaudiovolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSimpleAudioVolume(nint /* optional Guid */ AudioSessionGuid, uint StreamFlags, out ISimpleAudioVolume AudioVolume);
}
