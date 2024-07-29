#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdserviceprovider
[GeneratedComInterface, Guid("1dcb3a10-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDServiceProvider
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdserviceprovider-getdevicecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdserviceprovider-enumdevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevices([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPEnumDevice>))] out IMDSPEnumDevice ppEnumDevice);
}
