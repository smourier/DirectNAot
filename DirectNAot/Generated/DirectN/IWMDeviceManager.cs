#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdevicemanager
[GeneratedComInterface, Guid("1dcb3a00-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDeviceManager
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager-getrevision
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRevision(out uint pdwRevision);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager-getdevicecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager-enumdevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevices(out IWMDMEnumDevice ppEnumDevice);
}
