#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsyncdevice
[GeneratedComInterface, Guid("82a2986c-0293-4fd0-b279-b21b86c058be")]
public partial interface IWMPSyncDevice
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_friendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_friendlyName(ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-put_friendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_friendlyName(BSTR bstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_devicename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_deviceName(ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_deviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_deviceId(ref BSTR pbstrDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_partnershipindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_partnershipIndex(ref int plIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_connected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_connected(ref VARIANT_BOOL pvbConnected);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_status(ref WMPDeviceStatus pwmpds);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_syncstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_syncState(ref WMPSyncState pwmpss);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-get_progress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_progress(ref int plProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrItemName, ref BSTR pbstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-createpartnership
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT createPartnership(VARIANT_BOOL vbShowUI);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-deletepartnership
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT deletePartnership();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT start();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stop();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-showsettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT showSettings();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice-isidentical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isIdentical([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSyncDevice>))] IWMPSyncDevice pDevice, ref VARIANT_BOOL pvbool);
}
