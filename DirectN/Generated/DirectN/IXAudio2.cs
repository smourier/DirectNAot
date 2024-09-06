#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2
[GeneratedComInterface, Guid("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d")]
public partial interface IXAudio2
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-registerforcallbacks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForCallbacks(IXAudio2EngineCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-unregisterforcallbacks
    [PreserveSig]
    void UnregisterForCallbacks(IXAudio2EngineCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-createsourcevoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSourceVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXAudio2SourceVoice>))] out IXAudio2SourceVoice ppSourceVoice, in WAVEFORMATEX pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback pCallback, nint /* optional XAUDIO2_VOICE_SENDS* */ pSendList, nint /* optional XAUDIO2_EFFECT_CHAIN* */ pEffectChain);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-createsubmixvoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSubmixVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXAudio2SubmixVoice>))] out IXAudio2SubmixVoice ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, nint /* optional XAUDIO2_VOICE_SENDS* */ pSendList, nint /* optional XAUDIO2_EFFECT_CHAIN* */ pEffectChain);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-createmasteringvoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMasteringVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXAudio2MasteringVoice>))] out IXAudio2MasteringVoice ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, PWSTR szDeviceId, nint /* optional XAUDIO2_EFFECT_CHAIN* */ pEffectChain, AUDIO_STREAM_CATEGORY StreamCategory);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-startengine
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartEngine();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-stopengine
    [PreserveSig]
    void StopEngine();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-commitchanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitChanges(uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-getperformancedata
    [PreserveSig]
    void GetPerformanceData(out XAUDIO2_PERFORMANCE_DATA pPerfData);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2-setdebugconfiguration
    [PreserveSig]
    void SetDebugConfiguration(nint /* optional XAUDIO2_DEBUG_CONFIGURATION* */ pDebugConfiguration, nint /* optional void* */ pReserved);
}
