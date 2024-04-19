namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaenginewebsupport
[GeneratedComInterface, Guid("ba2743a1-07e0-48ef-84b6-9a2ed023ca6c")]
public partial interface IMFMediaEngineWebSupport
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginewebsupport-shoulddelaytheloadevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool ShouldDelayTheLoadEvent();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginewebsupport-connectwebaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectWebAudio(uint dwSampleRate, out IAudioSourceProvider ppSourceProvider);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginewebsupport-disconnectwebaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisconnectWebAudio();
}
