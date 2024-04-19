namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfstreamsink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0a97b3cf-8e7c-4a3d-8f8c-0c843dc247fb")]
public partial interface IMFStreamSink : IMFMediaEventGenerator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-getmediasink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaSink(out IMFMediaSink ppMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-getidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdentifier(out uint pdwIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-getmediatypehandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeHandler(out IMFMediaTypeHandler ppHandler);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-processsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessSample(IMFSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-placemarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlaceMarker(MFSTREAMSINK_MARKER_TYPE eMarkerType, in PROPVARIANT pvarMarkerValue, in PROPVARIANT pvarContextValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamsink-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
}
