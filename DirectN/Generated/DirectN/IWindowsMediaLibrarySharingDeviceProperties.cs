#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/nn-wmlss-iwindowsmedialibrarysharingdeviceproperties
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c4623214-6b06-40c5-a623-b2ff4c076bfd")]
public partial interface IWindowsMediaLibrarySharingDeviceProperties : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdeviceproperties-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(int index, out IWindowsMediaLibrarySharingDeviceProperty property);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdeviceproperties-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int count);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdeviceproperties-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(BSTR name, out IWindowsMediaLibrarySharingDeviceProperty property);
}
