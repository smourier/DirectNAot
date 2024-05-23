#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-immdeviceenumerator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a95664d2-9614-4f35-a746-de8db63617e6")]
public partial interface IMMDeviceEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdeviceenumerator-enumaudioendpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAudioEndpoints(EDataFlow dataFlow, DEVICE_STATE dwStateMask, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDeviceCollection>))] out IMMDeviceCollection ppDevices);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdeviceenumerator-getdefaultaudioendpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] out IMMDevice ppEndpoint);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdeviceenumerator-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(PWSTR pwstrId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] out IMMDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdeviceenumerator-registerendpointnotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient pClient);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immdeviceenumerator-unregisterendpointnotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient pClient);
}
