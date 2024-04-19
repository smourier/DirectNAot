namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmusics/nn-dmusics-idirectmusicsynth8
[GeneratedComInterface, Guid("53cab625-2711-4c9f-9de7-1b7f925f6fc8")]
public partial interface IDirectMusicSynth8 : IDirectMusicSynth
{
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth8-playvoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayVoice(long rt, uint dwVoiceId, uint dwChannelGroup, uint dwChannel, uint dwDLId, int prPitch, int vrVolume, ulong stVoiceStart, ulong stLoopStart, ulong stLoopEnd);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth8-stopvoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopVoice(long rt, uint dwVoiceId);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth8-getvoicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVoiceState(ref uint dwVoice, uint cbVoice, ref DMUS_VOICE_STATE dwVoiceState);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth8-refresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh(uint dwDownloadID, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth8-assignchanneltobuses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AssignChannelToBuses(uint dwChannelGroup, uint dwChannel, ref uint pdwBuses, uint cBuses);
}
