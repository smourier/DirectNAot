namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioeffectsmanager
[GeneratedComInterface, Guid("4460b3ae-4b44-4527-8676-7548a8acd260")]
public partial interface IAudioEffectsManager
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioeffectsmanager-registeraudioeffectschangednotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAudioEffectsChangedNotificationCallback(IAudioEffectsChangedNotificationClient client);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioeffectsmanager-unregisteraudioeffectschangednotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterAudioEffectsChangedNotificationCallback(IAudioEffectsChangedNotificationClient client);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioeffectsmanager-getaudioeffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioEffects(out nint effects, ref uint numEffects);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioeffectsmanager-setaudioeffectstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioEffectState(Guid effectId, AUDIO_EFFECT_STATE state);
}
