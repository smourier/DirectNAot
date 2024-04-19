namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2sourcevoice
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IXAudio2SourceVoice : IXAudio2Voice
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(uint Flags, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(uint Flags, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-submitsourcebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubmitSourceBuffer(in XAUDIO2_BUFFER pBuffer, nint/* nint */ pBufferWMA);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-flushsourcebuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlushSourceBuffers();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-discontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Discontinuity();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-exitloop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExitLoop(uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-getstate
    [PreserveSig]
    void GetState(out XAUDIO2_VOICE_STATE pVoiceState, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-setfrequencyratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFrequencyRatio(float Ratio, uint OperationSet);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-getfrequencyratio
    [PreserveSig]
    void GetFrequencyRatio(out float pRatio);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2sourcevoice-setsourcesamplerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceSampleRate(uint NewSourceSampleRate);
}
