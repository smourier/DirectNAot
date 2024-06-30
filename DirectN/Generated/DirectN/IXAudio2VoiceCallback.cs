#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2voicecallback
public partial struct IXAudio2VoiceCallback
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassstart
    public readonly unsafe void OnVoiceProcessingPassStart(uint BytesRequired) =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*,uint, void>)(((void**)*((void**)VTablePtr))[0]))((IXAudio2VoiceCallback*)VTablePtr, BytesRequired);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassend
    public readonly unsafe void OnVoiceProcessingPassEnd() =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void>)(((void**)*((void**)VTablePtr))[1]))((IXAudio2VoiceCallback*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onstreamend
    public readonly unsafe void OnStreamEnd() =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*, void>)(((void**)*((void**)VTablePtr))[2]))((IXAudio2VoiceCallback*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferstart
    public readonly unsafe void OnBufferStart(nint pBufferContext) =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*,nint, void>)(((void**)*((void**)VTablePtr))[3]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferend
    public readonly unsafe void OnBufferEnd(nint pBufferContext) =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*,nint, void>)(((void**)*((void**)VTablePtr))[4]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onloopend
    public readonly unsafe void OnLoopEnd(nint pBufferContext) =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*,nint, void>)(((void**)*((void**)VTablePtr))[5]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceerror
    public readonly unsafe void OnVoiceError(nint pBufferContext, HRESULT Error) =>
        ((delegate* unmanaged<IXAudio2VoiceCallback*,nint,HRESULT, void>)(((void**)*((void**)VTablePtr))[6]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext, Error);
}
