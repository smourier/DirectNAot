namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturephotosink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("d2d43cc8-48bb-4aa7-95db-10c06977e777")]
public partial interface IMFCapturePhotoSink : IMFCaptureSink
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturephotosink-setoutputfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFileName(PWSTR fileName);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturephotosink-setsamplecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleCallback(IMFCaptureEngineOnSampleCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturephotosink-setoutputbytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputByteStream(IMFByteStream pByteStream);
}
