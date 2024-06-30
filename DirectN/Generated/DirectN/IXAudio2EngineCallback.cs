#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2enginecallback
public partial struct IXAudio2EngineCallback
{
    public static readonly IXAudio2EngineCallback Null = new();
    
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassstart
    public readonly unsafe void OnProcessingPassStart() =>
        ((delegate* unmanaged<IXAudio2EngineCallback*, void>)(((void**)*((void**)VTablePtr))[0]))((IXAudio2EngineCallback*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassend
    public readonly unsafe void OnProcessingPassEnd() =>
        ((delegate* unmanaged<IXAudio2EngineCallback*, void>)(((void**)*((void**)VTablePtr))[1]))((IXAudio2EngineCallback*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-oncriticalerror
    public readonly unsafe void OnCriticalError(HRESULT Error) =>
        ((delegate* unmanaged<IXAudio2EngineCallback*,HRESULT, void>)(((void**)*((void**)VTablePtr))[2]))((IXAudio2EngineCallback*)VTablePtr, Error);
}
