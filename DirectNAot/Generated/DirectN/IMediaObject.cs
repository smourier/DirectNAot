#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-imediaobject
[GeneratedComInterface, Guid("d8ad0f58-5494-4102-97c5-ec798e59bcf4")]
public partial interface IMediaObject
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcInputStreams, out uint pcOutputStreams);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputstreaminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamInfo(uint dwInputStreamIndex, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getoutputstreaminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamInfo(uint dwOutputStreamIndex, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputType(uint dwInputStreamIndex, uint dwTypeIndex, nint /* optional DMO_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getoutputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputType(uint dwOutputStreamIndex, uint dwTypeIndex, nint /* optional DMO_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-setinputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputType(uint dwInputStreamIndex, nint /* optional DMO_MEDIA_TYPE* */ pmt, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-setoutputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputType(uint dwOutputStreamIndex, nint /* optional DMO_MEDIA_TYPE* */ pmt, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputCurrentType(uint dwInputStreamIndex, out DMO_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getoutputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCurrentType(uint dwOutputStreamIndex, out DMO_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputsizeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputSizeInfo(uint dwInputStreamIndex, out uint pcbSize, out uint pcbMaxLookahead, out uint pcbAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getoutputsizeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputSizeInfo(uint dwOutputStreamIndex, out uint pcbSize, out uint pcbAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputmaxlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputMaxLatency(uint dwInputStreamIndex, out long prtMaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-setinputmaxlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputMaxLatency(uint dwInputStreamIndex, long rtMaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-discontinuity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Discontinuity(uint dwInputStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-allocatestreamingresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateStreamingResources();
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-freestreamingresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreeStreamingResources();
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-getinputstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStatus(uint dwInputStreamIndex, out uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-processinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessInput(uint dwInputStreamIndex, IMediaBuffer pBuffer, uint dwFlags, long rtTimestamp, long rtTimelength);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-processoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessOutput(uint dwFlags, uint cOutputBufferCount, [MarshalUsing(CountElementName = nameof(cOutputBufferCount))] ref DMO_OUTPUT_DATA_BUFFER[] pOutputBuffers, out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobject-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(int bLock);
}
