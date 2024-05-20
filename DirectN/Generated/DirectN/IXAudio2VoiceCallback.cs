#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2voicecallback
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IXAudio2VoiceCallback
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassstart
    [PreserveSig]
    void OnVoiceProcessingPassStart(uint BytesRequired);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceprocessingpassend
    [PreserveSig]
    void OnVoiceProcessingPassEnd();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onstreamend
    [PreserveSig]
    void OnStreamEnd();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferstart
    [PreserveSig]
    void OnBufferStart(nint pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onbufferend
    [PreserveSig]
    void OnBufferEnd(nint pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onloopend
    [PreserveSig]
    void OnLoopEnd(nint pBufferContext);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2voicecallback-onvoiceerror
    [PreserveSig]
    void OnVoiceError(nint pBufferContext, HRESULT Error);
}
