#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfplugincontrol
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5c6c44bf-1db6-435b-9249-e8cd10fdec96")]
public partial interface IMFPluginControl
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-getpreferredclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredClsid(uint pluginType, PWSTR selector, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-getpreferredclsidbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredClsidByIndex(uint pluginType, uint index, out PWSTR selector, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-setpreferredclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreferredClsid(uint pluginType, PWSTR selector, nint /* optional Guid* */ clsid);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-isdisabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDisabled(uint pluginType, in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-getdisabledbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisabledByIndex(uint pluginType, uint index, out Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol-setdisabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisabled(uint pluginType, in Guid clsid, [MarshalAs(UnmanagedType.U4)] bool disabled);
}
