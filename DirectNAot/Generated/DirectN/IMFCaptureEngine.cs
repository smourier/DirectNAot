namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcaptureengine
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a6bba433-176b-48b2-b375-53aa03473207")]
public partial interface IMFCaptureEngine
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IMFCaptureEngineOnEventCallback pEventCallback, IMFAttributes? pAttributes, nint pAudioSource, nint pVideoSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-startpreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartPreview();
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-stoppreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopPreview();
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-startrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartRecord();
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-stoprecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopRecord([MarshalAs(UnmanagedType.U4)] bool bFinalize, [MarshalAs(UnmanagedType.U4)] bool bFlushUnprocessedSamples);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-takephoto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TakePhoto();
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-getsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSink(MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType, out IMFCaptureSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengine-getsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSource(out IMFCaptureSource ppSource);
}
