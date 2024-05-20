#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamextdevice
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b5730a90-1a2c-11cf-8c23-00aa006b6814")]
public partial interface IAMExtDevice
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-getcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapability(int Capability, out int pValue, out double pdblValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-get_externaldeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExternalDeviceID(out PWSTR ppszData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-get_externaldeviceversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExternalDeviceVersion(out PWSTR ppszData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-put_devicepower
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DevicePower(int PowerMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-get_devicepower
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DevicePower(out int pPowerMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-calibrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Calibrate(nuint hEvent, int Mode, out int pStatus);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-put_deviceport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DevicePort(int DevicePort);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamextdevice-get_deviceport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DevicePort(out int pDevicePort);
}
