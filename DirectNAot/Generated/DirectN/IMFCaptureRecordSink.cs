namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturerecordsink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3323b55a-f92a-4fe2-8edc-e9bfc0634d77")]
public partial interface IMFCaptureRecordSink : IMFCaptureSink
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-setoutputbytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputByteStream(IMFByteStream pByteStream, in Guid guidContainerType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-setoutputfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFileName(PWSTR fileName);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-setsamplecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleCallback(uint dwStreamSinkIndex, IMFCaptureEngineOnSampleCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-setcustomsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCustomSink(IMFMediaSink pMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-getrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRotation(uint dwStreamIndex, out uint pdwRotationValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturerecordsink-setrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotation(uint dwStreamIndex, uint dwRotationValue);
}
