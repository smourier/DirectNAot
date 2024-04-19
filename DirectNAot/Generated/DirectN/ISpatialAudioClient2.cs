namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nn-spatialaudioclient-ispatialaudioclient2
[GeneratedComInterface, Guid("caabe452-a66a-4bee-a93e-e320463f6a53")]
public partial interface ISpatialAudioClient2 : ISpatialAudioClient
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient2-isoffloadcapable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY category, [MarshalAs(UnmanagedType.U4)] out bool isOffloadCapable);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudioclient/nf-spatialaudioclient-ispatialaudioclient2-getmaxframecountforcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxFrameCountForCategory(AUDIO_STREAM_CATEGORY category, [MarshalAs(UnmanagedType.U4)] bool offloadEnabled, in WAVEFORMATEX objectFormat, out uint frameCountPerBuffer);
}
