#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayer2
[GeneratedComInterface, Guid("0e6b01d1-d407-4c85-bf5f-1c01f6150280")]
public partial interface IWMPPlayer2 : IWMPCore
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
    HRESULT get_uiMode(ref BSTR pbstrMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer2-get_stretchtofit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_stretchToFit(ref VARIANT_BOOL pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer2-put_stretchtofit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_stretchToFit(VARIANT_BOOL bEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer2-get_windowlessvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_windowlessVideo(ref VARIANT_BOOL pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayer2-put_windowlessvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_windowlessVideo(VARIANT_BOOL bEnabled);
}
