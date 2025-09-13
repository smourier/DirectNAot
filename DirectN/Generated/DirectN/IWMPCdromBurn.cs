#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcdromburn
[GeneratedComInterface, Guid("bd94dbeb-417f-4928-aa06-087d56ed9b59")]
public partial interface IWMPCdromBurn
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT isAvailable(BSTR bstrItem, ref VARIANT_BOOL pIsAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrItem, out BSTR pbstrVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-get_label
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_label(out BSTR pbstrLabel);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-put_label
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_label(BSTR bstrLabel);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-get_burnformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_burnFormat(ref WMPBurnFormat pwmpbf);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-put_burnformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_burnFormat(WMPBurnFormat wmpbf);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-get_burnplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_burnPlaylist([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] out IWMPPlaylist ppPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-put_burnplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_burnPlaylist([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pPlaylist);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-refreshstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT refreshStatus();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-get_burnstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_burnState(ref WMPBurnState pwmpbs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-get_burnprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_burnProgress(ref int plProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-startburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startBurn();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-stopburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stopBurn();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromburn-erase
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT erase();
}
