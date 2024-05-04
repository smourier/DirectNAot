#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsettings2
[GeneratedComInterface, Guid("fda937a4-eece-4da5-a0b6-39bf89ade2c2")]
public partial interface IWMPSettings2 : IWMPSettings
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings2-get_defaultaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_defaultAudioLanguage(ref int plLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings2-get_mediaaccessrights
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_mediaAccessRights(ref BSTR pbstrRights);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings2-requestmediaaccessrights
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT requestMediaAccessRights(BSTR bstrDesiredAccess, ref VARIANT_BOOL pvbAccepted);
}
