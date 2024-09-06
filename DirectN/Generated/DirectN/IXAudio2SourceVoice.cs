#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2sourcevoice
public partial struct IXAudio2SourceVoice
{
    public static readonly IXAudio2SourceVoice Null = new();
    
    public nint VTablePtr;
    
    // IXAudio2Voice methods
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getvoicedetails
    public readonly unsafe void GetVoiceDetails(ref XAUDIO2_VOICE_DETAILS pVoiceDetails) =>
        ((delegate* unmanaged<IXAudio2Voice*,XAUDIO2_VOICE_DETAILS*, void>)(((void**)*((void**)VTablePtr))[0]))((IXAudio2Voice*)VTablePtr, (XAUDIO2_VOICE_DETAILS*)Unsafe.AsPointer(ref pVoiceDetails));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputvoices
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetOutputVoices(nint /* optional XAUDIO2_VOICE_SENDS* */ pSendList) =>
        ((delegate* unmanaged<IXAudio2Voice*,nint, HRESULT>)(((void**)*((void**)VTablePtr))[1]))((IXAudio2Voice*)VTablePtr, pSendList);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-seteffectchain
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetEffectChain(nint /* optional XAUDIO2_EFFECT_CHAIN* */ pEffectChain) =>
        ((delegate* unmanaged<IXAudio2Voice*,nint, HRESULT>)(((void**)*((void**)VTablePtr))[2]))((IXAudio2Voice*)VTablePtr, pEffectChain);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-enableeffect
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT EnableEffect(uint EffectIndex, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[3]))((IXAudio2Voice*)VTablePtr, EffectIndex, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-disableeffect
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT DisableEffect(uint EffectIndex, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[4]))((IXAudio2Voice*)VTablePtr, EffectIndex, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-geteffectstate
    public readonly unsafe void GetEffectState(uint EffectIndex, ref BOOL pEnabled) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,BOOL*, void>)(((void**)*((void**)VTablePtr))[5]))((IXAudio2Voice*)VTablePtr, EffectIndex, (BOOL*)Unsafe.AsPointer(ref pEnabled));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-seteffectparameters
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetEffectParameters(uint EffectIndex, nint pParameters, uint ParametersByteSize, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,nint,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[6]))((IXAudio2Voice*)VTablePtr, EffectIndex, pParameters, ParametersByteSize, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-geteffectparameters
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetEffectParameters(uint EffectIndex, nint pParameters, uint ParametersByteSize) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,nint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[7]))((IXAudio2Voice*)VTablePtr, EffectIndex, pParameters, ParametersByteSize);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setfilterparameters
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetFilterParameters(in XAUDIO2_FILTER_PARAMETERS pParameters, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,XAUDIO2_FILTER_PARAMETERS,uint, HRESULT>)(((void**)*((void**)VTablePtr))[8]))((IXAudio2Voice*)VTablePtr, pParameters, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getfilterparameters
    public readonly unsafe void GetFilterParameters(ref XAUDIO2_FILTER_PARAMETERS pParameters) =>
        ((delegate* unmanaged<IXAudio2Voice*,XAUDIO2_FILTER_PARAMETERS*, void>)(((void**)*((void**)VTablePtr))[9]))((IXAudio2Voice*)VTablePtr, (XAUDIO2_FILTER_PARAMETERS*)Unsafe.AsPointer(ref pParameters));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputfilterparameters
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetOutputFilterParameters(IXAudio2Voice pDestinationVoice, in XAUDIO2_FILTER_PARAMETERS pParameters, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,IXAudio2Voice,XAUDIO2_FILTER_PARAMETERS,uint, HRESULT>)(((void**)*((void**)VTablePtr))[10]))((IXAudio2Voice*)VTablePtr, pDestinationVoice, pParameters, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getoutputfilterparameters
    public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice pDestinationVoice, ref XAUDIO2_FILTER_PARAMETERS pParameters) =>
        ((delegate* unmanaged<IXAudio2Voice*,IXAudio2Voice,XAUDIO2_FILTER_PARAMETERS*, void>)(((void**)*((void**)VTablePtr))[11]))((IXAudio2Voice*)VTablePtr, pDestinationVoice, (XAUDIO2_FILTER_PARAMETERS*)Unsafe.AsPointer(ref pParameters));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setvolume
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetVolume(float Volume, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,float,uint, HRESULT>)(((void**)*((void**)VTablePtr))[12]))((IXAudio2Voice*)VTablePtr, Volume, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getvolume
    public readonly unsafe void GetVolume(ref float pVolume) =>
        ((delegate* unmanaged<IXAudio2Voice*,float*, void>)(((void**)*((void**)VTablePtr))[13]))((IXAudio2Voice*)VTablePtr, (float*)Unsafe.AsPointer(ref pVolume));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setchannelvolumes
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetChannelVolumes(uint Channels, [In][MarshalUsing(CountElementName = nameof(Channels))] float[] pVolumes, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,float[],uint, HRESULT>)(((void**)*((void**)VTablePtr))[14]))((IXAudio2Voice*)VTablePtr, Channels, pVolumes, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getchannelvolumes
    public readonly unsafe void GetChannelVolumes(uint Channels, [In][Out][MarshalUsing(CountElementName = nameof(Channels))] float[] pVolumes) =>
        ((delegate* unmanaged<IXAudio2Voice*,uint,float[], void>)(((void**)*((void**)VTablePtr))[15]))((IXAudio2Voice*)VTablePtr, Channels, pVolumes);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-setoutputmatrix
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetOutputMatrix(IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, in float pLevelMatrix, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2Voice*,IXAudio2Voice,uint,uint,float,uint, HRESULT>)(((void**)*((void**)VTablePtr))[16]))((IXAudio2Voice*)VTablePtr, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-getoutputmatrix
    public readonly unsafe void GetOutputMatrix(IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix) =>
        ((delegate* unmanaged<IXAudio2Voice*,IXAudio2Voice,uint,uint,float*, void>)(((void**)*((void**)VTablePtr))[17]))((IXAudio2Voice*)VTablePtr, pDestinationVoice, SourceChannels, DestinationChannels, (float*)Unsafe.AsPointer(ref pLevelMatrix));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voice-destroyvoice
    public readonly unsafe void DestroyVoice() =>
        ((delegate* unmanaged<IXAudio2Voice*, void>)(((void**)*((void**)VTablePtr))[18]))((IXAudio2Voice*)VTablePtr);
    
    // IXAudio2SourceVoice methods
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-start
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT Start(uint Flags, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[19]))((IXAudio2SourceVoice*)VTablePtr, Flags, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-stop
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT Stop(uint Flags, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[20]))((IXAudio2SourceVoice*)VTablePtr, Flags, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-submitsourcebuffer
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SubmitSourceBuffer(in XAUDIO2_BUFFER pBuffer, nint /* optional XAUDIO2_BUFFER_WMA* */ pBufferWMA) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,XAUDIO2_BUFFER,nint, HRESULT>)(((void**)*((void**)VTablePtr))[21]))((IXAudio2SourceVoice*)VTablePtr, pBuffer, pBufferWMA);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-flushsourcebuffers
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT FlushSourceBuffers() =>
        ((delegate* unmanaged<IXAudio2SourceVoice*, HRESULT>)(((void**)*((void**)VTablePtr))[22]))((IXAudio2SourceVoice*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-discontinuity
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT Discontinuity() =>
        ((delegate* unmanaged<IXAudio2SourceVoice*, HRESULT>)(((void**)*((void**)VTablePtr))[23]))((IXAudio2SourceVoice*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-exitloop
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT ExitLoop(uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,uint, HRESULT>)(((void**)*((void**)VTablePtr))[24]))((IXAudio2SourceVoice*)VTablePtr, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-getstate
    public readonly unsafe void GetState(ref XAUDIO2_VOICE_STATE pVoiceState, uint Flags) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,XAUDIO2_VOICE_STATE*,uint, void>)(((void**)*((void**)VTablePtr))[25]))((IXAudio2SourceVoice*)VTablePtr, (XAUDIO2_VOICE_STATE*)Unsafe.AsPointer(ref pVoiceState), Flags);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-setfrequencyratio
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetFrequencyRatio(float Ratio, uint OperationSet) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,float,uint, HRESULT>)(((void**)*((void**)VTablePtr))[26]))((IXAudio2SourceVoice*)VTablePtr, Ratio, OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-getfrequencyratio
    public readonly unsafe void GetFrequencyRatio(ref float pRatio) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,float*, void>)(((void**)*((void**)VTablePtr))[27]))((IXAudio2SourceVoice*)VTablePtr, (float*)Unsafe.AsPointer(ref pRatio));
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-setsourcesamplerate
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetSourceSampleRate(uint NewSourceSampleRate) =>
        ((delegate* unmanaged<IXAudio2SourceVoice*,uint, HRESULT>)(((void**)*((void**)VTablePtr))[28]))((IXAudio2SourceVoice*)VTablePtr, NewSourceSampleRate);
}
