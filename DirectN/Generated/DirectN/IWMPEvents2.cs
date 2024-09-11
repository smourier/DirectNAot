#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpevents2
[GeneratedComInterface, Guid("1e7601fa-47ea-4107-9ea9-9004ed9684ff")]
public partial interface IWMPEvents2 : IWMPEvents
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-deviceconnect
    [PreserveSig]
    void DeviceConnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-devicedisconnect
    [PreserveSig]
    void DeviceDisconnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-devicestatuschange
    [PreserveSig]
    void DeviceStatusChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, WMPDeviceStatus NewStatus);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-devicesyncstatechange
    [PreserveSig]
    void DeviceSyncStateChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, WMPSyncState NewState);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-devicesyncerror
    [PreserveSig]
    void DeviceSyncError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents2-createpartnershipcomplete
    [PreserveSig]
    void CreatePartnershipComplete([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, HRESULT hrResult);
}
