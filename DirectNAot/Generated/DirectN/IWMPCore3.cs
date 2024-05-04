#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcore3
[GeneratedComInterface, Guid("7587c667-628f-499f-88e7-6a6f4e888464")]
public partial interface IWMPCore3 : IWMPCore2
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore3-newplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT newPlaylist(BSTR bstrName, BSTR bstrURL, out IWMPPlaylist ppPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore3-newmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT newMedia(BSTR bstrURL, out IWMPMedia ppMedia);
}
