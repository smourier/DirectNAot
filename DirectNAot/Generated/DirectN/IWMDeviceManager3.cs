#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdevicemanager3
[GeneratedComInterface, Guid("af185c41-100d-46ed-be2e-9ce8c44594ef")]
public partial interface IWMDeviceManager3 : IWMDeviceManager2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdevicemanager3-setdeviceenumpreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeviceEnumPreference(uint dwEnumPref);
}
