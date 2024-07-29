#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdserviceprovider3
[GeneratedComInterface, Guid("4ed13ef3-a971-4d19-9f51-0e1826b2da57")]
public partial interface IMDServiceProvider3 : IMDServiceProvider2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdserviceprovider3-setdeviceenumpreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeviceEnumPreference(uint dwEnumPref);
}
