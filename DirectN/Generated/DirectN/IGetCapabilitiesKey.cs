#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-igetcapabilitieskey
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a8809222-07bb-48ea-951c-33158100625b")]
public partial interface IGetCapabilitiesKey
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igetcapabilitieskey-getcapabilitieskey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilitiesKey(out HKEY pHKey);
}
