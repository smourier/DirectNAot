#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2enginecallback
public partial struct IXAudio2EngineCallback
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassstart
    public unsafe void OnProcessingPassStart()
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2EngineCallback*, void>)(((void**)VTablePtr)[0]))((IXAudio2EngineCallback*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-onprocessingpassend
    public unsafe void OnProcessingPassEnd()
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2EngineCallback*, void>)(((void**)VTablePtr)[1]))((IXAudio2EngineCallback*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2enginecallback-oncriticalerror
    public unsafe void OnCriticalError(HRESULT Error)
    {
        ((delegate* unmanaged[MemberFunction]<IXAudio2EngineCallback*,HRESULT, void>)(((void**)VTablePtr)[2]))((IXAudio2EngineCallback*)VTablePtr, Error);
    }
}
