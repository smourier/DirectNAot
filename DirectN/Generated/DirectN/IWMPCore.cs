#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcore
[GeneratedComInterface, Guid("d84cca99-cce2-11d2-9ecc-0000f8085981")]
public partial interface IWMPCore : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT close();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_url
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_URL(ref BSTR pbstrURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-put_url
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_URL(BSTR bstrURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_openstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_openState(ref WMPOpenState pwmpos);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_playstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playState(ref WMPPlayState pwmpps);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_controls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_controls([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPControls>))] out IWMPControls ppControl);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_settings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_settings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSettings>))] out IWMPSettings ppSettings);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_currentmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentMedia([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] out IWMPMedia ppMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-put_currentmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentMedia([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_mediacollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_mediaCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMediaCollection>))] out IWMPMediaCollection ppMediaCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_playlistcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playlistCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylistCollection>))] out IWMPPlaylistCollection ppPlaylistCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_versioninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_versionInfo(ref BSTR pbstrVersionInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-launchurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT launchURL(BSTR bstrURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_network
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_network([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPNetwork>))] out IWMPNetwork ppQNI);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_currentplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentPlaylist([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] out IWMPPlaylist ppPL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-put_currentplaylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentPlaylist([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pPL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_cdromcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_cdromCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromCollection>))] out IWMPCdromCollection ppCdromCollection);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_closedcaption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_closedCaption([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPClosedCaption>))] out IWMPClosedCaption ppClosedCaption);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_isonline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isOnline(ref VARIANT_BOOL pfOnline);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_error
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_error([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPError>))] out IWMPError ppError);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcore-get_status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_status(ref BSTR pbstrStatus);
}
