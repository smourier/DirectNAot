#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayer3
[GeneratedComInterface, Guid("54062b68-052a-4c25-a39f-8b63346511d4")]
public partial interface IWMPPlayer3 : IWMPCore2
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
}
