#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2voicecallback
public partial struct IXAudio2VoiceCallback
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassstart
    public unsafe void OnVoiceProcessingPassStart(uint BytesRequired)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*,uint, void>)(((void**)VTablePtr)[0]))((IXAudio2VoiceCallback*)VTablePtr, BytesRequired);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassend
    public unsafe void OnVoiceProcessingPassEnd()
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*, void>)(((void**)VTablePtr)[1]))((IXAudio2VoiceCallback*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onstreamend
    public unsafe void OnStreamEnd()
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*, void>)(((void**)VTablePtr)[2]))((IXAudio2VoiceCallback*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferstart
    public unsafe void OnBufferStart(nint pBufferContext)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*,nint, void>)(((void**)VTablePtr)[3]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferend
    public unsafe void OnBufferEnd(nint pBufferContext)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*,nint, void>)(((void**)VTablePtr)[4]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onloopend
    public unsafe void OnLoopEnd(nint pBufferContext)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*,nint, void>)(((void**)VTablePtr)[5]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceerror
    public unsafe void OnVoiceError(nint pBufferContext, HRESULT Error)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2VoiceCallback*,nint,HRESULT, void>)(((void**)VTablePtr)[6]))((IXAudio2VoiceCallback*)VTablePtr, pBufferContext, Error);
    }
}
