#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayer4
[GeneratedComInterface, Guid("6c497d62-8919-413c-82db-e935fb3ec584")]
public partial interface IWMPPlayer4 : IWMPCore3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_enabled(ref VARIANT_BOOL pbEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_enabled(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_fullScreen(ref VARIANT_BOOL pbFullScreen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_fullScreen(VARIANT_BOOL bFullScreen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_enableContextMenu(ref VARIANT_BOOL pbEnableContextMenu);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_enableContextMenu(VARIANT_BOOL bEnableContextMenu);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_uiMode(BSTR bstrMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_uiMode(out BSTR pbstrMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_stretchToFit(ref VARIANT_BOOL pbEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_stretchToFit(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_windowlessVideo(ref VARIANT_BOOL pbEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_windowlessVideo(VARIANT_BOOL bEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer4-get_isremote
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isRemote(ref VARIANT_BOOL pvarfIsRemote);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer4-get_playerapplication
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playerApplication([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlayerApplication>))] out IWMPPlayerApplication ppIWMPPlayerApplication);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer4-openplayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT openPlayer(BSTR bstrURL);
}
