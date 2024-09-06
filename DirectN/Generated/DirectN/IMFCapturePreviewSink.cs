#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturepreviewsink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("77346cfd-5b49-4d73-ace0-5b52a859f2e0")]
public partial interface IMFCapturePreviewSink : IMFCaptureSink
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setrenderhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderHandle(HANDLE handle);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setrendersurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderSurface(nint pSurface);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-updatevideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateVideo(nint /* optional MFVideoNormalizedRect* */ pSrc, nint /* optional RECT* */ pDst, nint /* optional COLORREF* */ pBorderClr);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setsamplecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleCallback(uint dwStreamSinkIndex, IMFCaptureEngineOnSampleCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-getmirrorstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMirrorState(out BOOL pfMirrorState);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setmirrorstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMirrorState(BOOL fMirrorState);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-getrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRotation(uint dwStreamIndex, out uint pdwRotationValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotation(uint dwStreamIndex, uint dwRotationValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturepreviewsink-setcustomsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCustomSink(IMFMediaSink pMediaSink);
}
