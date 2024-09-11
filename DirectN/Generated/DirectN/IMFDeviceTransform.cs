#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/nn-mftransform-imfdevicetransform
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("d818fbd8-fc46-42f2-87ac-1ea2d1f9bf32")]
public partial interface IMFDeviceTransform
{
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-initializetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getinputavailabletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputAvailableType(uint dwInputStreamID, uint dwTypeIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getinputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputCurrentType(uint dwInputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getinputstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamAttributes(uint dwInputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getoutputavailabletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputAvailableType(uint dwOutputStreamID, uint dwTypeIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getoutputcurrenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCurrentType(uint dwOutputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getoutputstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamAttributes(uint dwOutputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcInputStreams, out uint pcOutputStreams);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getstreamids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamIDs(uint dwInputIDArraySize, out uint pdwInputStreamIds, uint dwOutputIDArraySize, out uint pdwOutputStreamIds);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-processevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessEvent(uint dwInputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] IMFMediaEvent pEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-processinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessInput(uint dwInputStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pSample, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-processmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, nuint ulParam);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-processoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessOutput(uint dwFlags, uint cOutputBufferCount, ref MFT_OUTPUT_DATA_BUFFER pOutputSample, out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-setinputstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputStreamState(uint dwStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, DeviceStreamState value, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getinputstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamState(uint dwStreamID, out DeviceStreamState value);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-setoutputstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputStreamState(uint dwStreamID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, DeviceStreamState value, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getoutputstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStreamState(uint dwStreamID, out DeviceStreamState value);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-getinputstreampreferredstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamPreferredState(uint dwStreamID, out DeviceStreamState value, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-flushinputstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlushInputStream(uint dwStreamIndex, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-imfdevicetransform-flushoutputstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlushOutputStream(uint dwStreamIndex, uint dwFlags);
}
