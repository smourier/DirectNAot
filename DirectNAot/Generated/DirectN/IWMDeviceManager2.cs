namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdevicemanager2
[GeneratedComInterface, Guid("923e5249-8731-4c5b-9b1c-b8b60b6e46af")]
public partial interface IWMDeviceManager2 : IWMDeviceManager
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager2-getdevicefromcanonicalname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceFromCanonicalName(PWSTR pwszCanonicalName, out IWMDMDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager2-enumdevices2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevices2(out IWMDMEnumDevice ppEnumDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager2-reinitialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reinitialize();
}
