#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpconfig/nn-mpconfig-imixerpinconfig
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("593cdde1-0759-11d1-9e69-00c04fd7c15b")]
public partial interface IMixerPinConfig
{
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setrelativeposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRelativePosition(uint dwLeft, uint dwTop, uint dwRight, uint dwBottom);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getrelativeposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativePosition(ref uint pdwLeft, ref uint pdwTop, ref uint pdwRight, ref uint pdwBottom);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetZOrder(uint dwZOrder);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZOrder(ref uint pdwZOrder);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorKey(ref COLORKEY pColorKey);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorKey(ref COLORKEY pColorKey, ref uint pColor);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setblendingparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlendingParameter(uint dwBlendingParameter);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getblendingparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlendingParameter(ref uint pdwBlendingParameter);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(AM_ASPECT_RATIO_MODE amAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(ref AM_ASPECT_RATIO_MODE pamAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-setstreamtransparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamTransparent(BOOL bStreamTransparent);
    
    // https://learn.microsoft.com/windows/win32/api/mpconfig/nf-mpconfig-imixerpinconfig-getstreamtransparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamTransparent(ref BOOL pbStreamTransparent);
}
