namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsyncservices
[GeneratedComInterface, Guid("8b5050ff-e0a4-4808-b3a8-893a9e1ed894")]
public partial interface IWMPSyncServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncservices-get_devicecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_deviceCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncservices-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getDevice(int lIndex, out IWMPSyncDevice ppDevice);
}
