#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/nn-wmlss-iwindowsmedialibrarysharingdevices
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1803f9d6-fe6d-4546-bf5b-992fe8ec12d1")]
public partial interface IWindowsMediaLibrarySharingDevices : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevices-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(int index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWindowsMediaLibrarySharingDevice>))] out IWindowsMediaLibrarySharingDevice device);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int count);
    
    // https://learn.microsoft.com/windows/win32/api/wmlss/nf-wmlss-iwindowsmedialibrarysharingdevices-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(BSTR deviceID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWindowsMediaLibrarySharingDevice>))] out IWindowsMediaLibrarySharingDevice device);
}
