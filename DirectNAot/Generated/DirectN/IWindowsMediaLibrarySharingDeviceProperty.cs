#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/nn-wmlss-iwindowsmedialibrarysharingdeviceproperty
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("81e26927-7a7d-40a7-81d4-bddc02960e3e")]
public partial interface IWindowsMediaLibrarySharingDeviceProperty : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdeviceproperty-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdeviceproperty-get_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out VARIANT value);
}
