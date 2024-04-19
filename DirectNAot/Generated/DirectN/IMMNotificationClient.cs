namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-immnotificationclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7991eec9-7e89-4d85-8390-6c703cec60c0")]
public partial interface IMMNotificationClient
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-ondevicestatechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDeviceStateChanged(PWSTR pwstrDeviceId, DEVICE_STATE dwNewState);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-ondeviceadded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDeviceAdded(PWSTR pwstrDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-ondeviceremoved
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDeviceRemoved(PWSTR pwstrDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-ondefaultdevicechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDefaultDeviceChanged(EDataFlow flow, ERole role, PWSTR pwstrDefaultDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-onpropertyvaluechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPropertyValueChanged(PWSTR pwstrDeviceId, PROPERTYKEY key);
}
