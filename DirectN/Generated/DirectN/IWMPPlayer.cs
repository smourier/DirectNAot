#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayer
[GeneratedComInterface, Guid("6bf52a4f-394a-11d3-b153-00c04f79faa6")]
public partial interface IWMPPlayer : IWMPCore
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-get_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_enabled(ref VARIANT_BOOL pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-put_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_enabled(VARIANT_BOOL bEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-get_fullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_fullScreen(ref VARIANT_BOOL pbFullScreen);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-put_fullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_fullScreen(VARIANT_BOOL bFullScreen);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-get_enablecontextmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_enableContextMenu(ref VARIANT_BOOL pbEnableContextMenu);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-put_enablecontextmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_enableContextMenu(VARIANT_BOOL bEnableContextMenu);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-put_uimode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_uiMode(BSTR bstrMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer-get_uimode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_uiMode(ref BSTR pbstrMode);
}
