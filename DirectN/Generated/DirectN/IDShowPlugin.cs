#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-idshowplugin
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4746b7c8-700e-11d1-becc-00c04fb6e937")]
public partial interface IDShowPlugin
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-idshowplugin-get_url
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_URL(ref BSTR pURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-idshowplugin-get_useragent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserAgent(ref BSTR pUserAgent);
}
