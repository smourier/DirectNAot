namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpmediapluginregistrar
[GeneratedComInterface, Guid("68e27045-05bd-40b2-9720-23088c78e390")]
public partial interface IWMPMediaPluginRegistrar
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpmediapluginregistrar-wmpregisterplayerplugin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMPRegisterPlayerPlugin(PWSTR pwszFriendlyName, PWSTR pwszDescription, PWSTR pwszUninstallString, uint dwPriority, Guid guidPluginType, Guid clsid, uint cMediaTypes, nint pMediaTypes);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpmediapluginregistrar-wmpunregisterplayerplugin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMPUnRegisterPlayerPlugin(Guid guidPluginType, Guid clsid);
}
