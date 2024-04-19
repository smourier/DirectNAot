namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmnotification
[GeneratedComInterface, Guid("3f5e95c0-0f43-4ed4-93d2-c89a45d59b81")]
public partial interface IWMDMNotification
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmnotification-wmdmmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMDMMessage(uint dwMessageType, PWSTR pwszCanonicalName);
}
