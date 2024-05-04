#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/nn-mftransform-imftransform
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bf94c121-5b05-4e6f-8000-ba598961414d")]
public partial interface IMFTransform
{
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getstreamlimits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamLimits(out uint pdwInputMinimum, out uint pdwInputMaximum, out uint pdwOutputMinimum, out uint pdwOutputMaximum);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcInputStreams, out uint pcOutputStreams);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getstreamids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamIDs(uint dwInputIDArraySize, [MarshalUsing(CountElementName = nameof(dwInputIDArraySize))] out uint[] pdwInputIDs, uint dwOutputIDArraySize, [MarshalUsing(CountElementName = nameof(dwOutputIDArraySize))] out uint[] pdwOutputIDs);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getinputstreaminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamInfo(uint dwInputStreamID, out MFT_INPUT_STREAM_INFO pStreamInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getoutputstreaminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamInfo(uint dwOutputStreamID, out MFT_OUTPUT_STREAM_INFO pStreamInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(out IMFAttributes pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getinputstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamAttributes(uint dwInputStreamID, out IMFAttributes pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getoutputstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamAttributes(uint dwOutputStreamID, out IMFAttributes pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-deleteinputstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteInputStream(uint dwStreamID);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-addinputstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddInputStreams(uint cStreams, in uint adwStreamIDs);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getinputavailabletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputAvailableType(uint dwInputStreamID, uint dwTypeIndex, out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getoutputavailabletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputAvailableType(uint dwOutputStreamID, uint dwTypeIndex, out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-setinputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputType(uint dwInputStreamID, IMFMediaType pType, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-setoutputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputType(uint dwOutputStreamID, IMFMediaType pType, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getinputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputCurrentType(uint dwInputStreamID, out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getoutputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCurrentType(uint dwOutputStreamID, out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getinputstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStatus(uint dwInputStreamID, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-getoutputstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStatus(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-setoutputbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputBounds(long hnsLowerBound, long hnsUpperBound);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-processevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessEvent(uint dwInputStreamID, IMFMediaEvent pEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-processmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, nuint ulParam);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-processinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessInput(uint dwInputStreamID, IMFSample pSample, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imftransform-processoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessOutput(uint dwFlags, uint cOutputBufferCount, [MarshalUsing(CountElementName = nameof(cOutputBufferCount))] ref MFT_OUTPUT_DATA_BUFFER[] pOutputSamples, out uint pdwStatus);
}
