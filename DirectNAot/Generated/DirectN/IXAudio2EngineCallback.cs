#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2enginecallback
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IXAudio2EngineCallback
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassstart
    [PreserveSig]
    void OnProcessingPassStart();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassend
    [PreserveSig]
    void OnProcessingPassEnd();
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-oncriticalerror
    [PreserveSig]
    void OnCriticalError(HRESULT Error);
}
