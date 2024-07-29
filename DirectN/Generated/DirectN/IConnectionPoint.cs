#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iconnectionpoint
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b286-bab4-101a-b69c-00aa00341d07")]
public partial interface IConnectionPoint
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpoint-getconnectioninterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectionInterface(out Guid pIID);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpoint-getconnectionpointcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectionPointContainer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionPointContainer>))] out IConnectionPointContainer ppCPC);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpoint-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(nint pUnkSink, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpoint-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpoint-enumconnections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumConnections([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumConnections>))] out IEnumConnections ppEnum);
}
