namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iaudiosystemeffects2
[GeneratedComInterface, Guid("bafe99d2-7436-44ce-9e0e-4d89afbfff56")]
public partial interface IAudioSystemEffects2 : IAudioSystemEffects
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudiosystemeffects2-geteffectslist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectsList(out nint ppEffectsIds, out uint pcEffects, HANDLE Event);
}
