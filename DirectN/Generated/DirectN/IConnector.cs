#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iconnector
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9c2c4058-23f5-41de-877a-df3af236a09e")]
public partial interface IConnector
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out ConnectorType pType);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-getdataflow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataFlow(out DataFlow pFlow);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-connectto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectTo(IConnector pConnectTo);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-isconnected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsConnected(out BOOL pbConnected);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-getconnectedto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectedTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnector>))] out IConnector ppConTo);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-getconnectoridconnectedto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectorIdConnectedTo(out PWSTR ppwstrConnectorId);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iconnector-getdeviceidconnectedto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceIdConnectedTo(out PWSTR ppwstrDeviceId);
}
