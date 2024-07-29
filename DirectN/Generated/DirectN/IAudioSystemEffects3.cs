#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nn-audioengineextensionapo-iaudiosystemeffects3
[GeneratedComInterface, Guid("c58b31cd-fc6a-4255-bc1f-ad29bb0a4a17")]
public partial interface IAudioSystemEffects3 : IAudioSystemEffects2
{
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudiosystemeffects3-getcontrollablesystemeffectslist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControllableSystemEffectsList(out nint effects, out uint numEffects, HANDLE @event);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudiosystemeffects3-setaudiosystemeffectstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioSystemEffectState(Guid effectId, AUDIO_SYSTEMEFFECT_STATE state);
}
