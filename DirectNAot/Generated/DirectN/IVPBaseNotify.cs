namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vpnotify/nn-vpnotify-ivpbasenotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IVPBaseNotify
{
    // https://learn.microsoft.com/windows/win32/api/vpnotify/nf-vpnotify-ivpbasenotify-renegotiatevpparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenegotiateVPParameters();
}
