#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsinkwriter
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3137f1cd-fe5e-4805-a5d8-fb477448cb3d")]
public partial interface IMFSinkWriter
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream(IMFMediaType pTargetMediaType, out uint pdwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-setinputmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputMediaType(uint dwStreamIndex, IMFMediaType pInputMediaType, IMFAttributes? pEncodingParameters);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-beginwriting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginWriting();
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-writesample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteSample(uint dwStreamIndex, IMFSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-sendstreamtick
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendStreamTick(uint dwStreamIndex, long llTimestamp);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-placemarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlaceMarker(uint dwStreamIndex, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-notifyendofsegment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyEndOfSegment(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-finalize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Finalize();
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-getserviceforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceForStream(uint dwStreamIndex, in Guid guidService, in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriter-getstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatistics(uint dwStreamIndex, out MF_SINK_WRITER_STATISTICS pStats);
}
