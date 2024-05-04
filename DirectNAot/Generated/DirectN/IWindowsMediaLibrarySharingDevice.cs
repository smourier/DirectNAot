#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/nn-wmlss-iwindowsmedialibrarysharingdevice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3dccc293-4fd9-4191-a25b-8e57c5d27bd4")]
public partial interface IWindowsMediaLibrarySharingDevice : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevice-get_deviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DeviceID(out BSTR deviceID);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevice-get_authorization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Authorization(out WindowsMediaLibrarySharingDeviceAuthorizationStatus authorization);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevice-put_authorization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Authorization(WindowsMediaLibrarySharingDeviceAuthorizationStatus authorization);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevice-get_properties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Properties(out IWindowsMediaLibrarySharingDeviceProperties deviceProperties);
}
