namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidgenericsink
[GeneratedComInterface, Guid("6c29b41d-455b-4c33-963a-0d28e5e555ea")]
public partial interface IMSVidGenericSink : IMSVidOutputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgenericsink-setsinkfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSinkFilter(BSTR bstrName);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgenericsink-get_sinkstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SinkStreams(out MSVidSinkStreams pStreams);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgenericsink-put_sinkstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SinkStreams(MSVidSinkStreams Streams);
}
