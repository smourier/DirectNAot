#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ipin
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86891-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IPin
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect(IPin pReceivePin, nint /* optional AM_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-receiveconnection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReceiveConnection(IPin pConnector, in AM_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-connectedto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectedTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] out IPin pPin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-connectionmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectionMediaType(out AM_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-querypininfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryPinInfo(out PIN_INFO pInfo);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-querydirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryDirection(out PIN_DIRECTION pPinDir);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-queryid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryId(out PWSTR Id);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-queryaccept
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAccept(in AM_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-enummediatypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMediaTypes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMediaTypes>))] out IEnumMediaTypes ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-queryinternalconnections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryInternalConnections(nint /* optional IPin* */ apPin, ref uint nPin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-endofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndOfStream();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-beginflush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFlush();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-endflush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFlush();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipin-newsegment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewSegment(long tStart, long tStop, double dRate);
}
