namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdserviceprovider2
[GeneratedComInterface, Guid("b2fa24b7-cda3-4694-9862-413ae1a34819")]
public partial interface IMDServiceProvider2 : IMDServiceProvider
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdserviceprovider2-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(PWSTR pwszDevicePath, out uint pdwCount, out nint pppDeviceArray);
}
