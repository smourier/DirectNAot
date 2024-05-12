#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2voice
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IXAudio2Voice
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getvoicedetails
    [PreserveSig]
    void GetVoiceDetails(out XAUDIO2_VOICE_DETAILS pVoiceDetails);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputvoices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputVoices(nint /* optional XAUDIO2_VOICE_SENDS* */ pSendList);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-seteffectchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffectChain(nint /* optional XAUDIO2_EFFECT_CHAIN* */ pEffectChain);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-enableeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableEffect(uint EffectIndex, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-disableeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableEffect(uint EffectIndex, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-geteffectstate
    [PreserveSig]
    void GetEffectState(uint EffectIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-seteffectparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffectParameters(uint EffectIndex, nint pParameters, uint ParametersByteSize, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-geteffectparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectParameters(uint EffectIndex, nint pParameters, uint ParametersByteSize);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setfilterparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilterParameters(in XAUDIO2_FILTER_PARAMETERS pParameters, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getfilterparameters
    [PreserveSig]
    void GetFilterParameters(out XAUDIO2_FILTER_PARAMETERS pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputfilterparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFilterParameters(IXAudio2Voice? pDestinationVoice, in XAUDIO2_FILTER_PARAMETERS pParameters, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getoutputfilterparameters
    [PreserveSig]
    void GetOutputFilterParameters(IXAudio2Voice? pDestinationVoice, out XAUDIO2_FILTER_PARAMETERS pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolume(float Volume, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getvolume
    [PreserveSig]
    void GetVolume(out float pVolume);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setchannelvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolumes(uint Channels, [MarshalUsing(CountElementName = nameof(Channels))] in float[] pVolumes, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getchannelvolumes
    [PreserveSig]
    void GetChannelVolumes(uint Channels, [MarshalUsing(CountElementName = nameof(Channels))] ref float[] pVolumes);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputMatrix(IXAudio2Voice? pDestinationVoice, uint SourceChannels, uint DestinationChannels, in float pLevelMatrix, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getoutputmatrix
    [PreserveSig]
    void GetOutputMatrix(IXAudio2Voice? pDestinationVoice, uint SourceChannels, uint DestinationChannels, out float pLevelMatrix);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-destroyvoice
    [PreserveSig]
    void DestroyVoice();
}
