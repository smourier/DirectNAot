namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturesink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("72d6135b-35e9-412c-b926-fd5265f2a885")]
public partial interface IMFCaptureSink
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink-getoutputmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputMediaType(uint dwSinkStreamIndex, nint/* nint */ ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink-getservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetService(uint dwSinkStreamIndex, in Guid rguidService, in Guid riid, nint/* nint */ ppUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream(uint dwSourceStreamIndex, IMFMediaType pMediaType, IMFAttributes pAttributes, nint/* nint */ pdwSinkStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink-prepare
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Prepare();
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesink-removeallstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllStreams();
}
