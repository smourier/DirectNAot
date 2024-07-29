#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdeviceregistration
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("f6211f03-8d21-4e94-93e6-8510805f2d99")]
public partial interface IWMDeviceRegistration
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-registerdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDevice(uint dwRegisterType, nint /* byte array */ pbCertificate, uint cbCertificate, DRM_VAL16 SerialNumber, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMRegisteredDevice>))] out IWMRegisteredDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-unregisterdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterDevice(uint dwRegisterType, nint /* byte array */ pbCertificate, uint cbCertificate, DRM_VAL16 SerialNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-getregistrationstats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegistrationStats(uint dwRegisterType, out uint pcRegisteredDevices);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-getfirstregistereddevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFirstRegisteredDevice(uint dwRegisterType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMRegisteredDevice>))] out IWMRegisteredDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-getnextregistereddevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextRegisteredDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMRegisteredDevice>))] out IWMRegisteredDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdeviceregistration-getregistereddevicebyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegisteredDeviceByID(uint dwRegisterType, nint /* byte array */ pbCertificate, uint cbCertificate, DRM_VAL16 SerialNumber, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMRegisteredDevice>))] out IWMRegisteredDevice ppDevice);
}
