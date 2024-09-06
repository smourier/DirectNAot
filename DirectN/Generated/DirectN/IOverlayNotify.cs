#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ioverlaynotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a0-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IOverlayNotify
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlaynotify-onpalettechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPaletteChange(uint dwColors, in PALETTEENTRY pPalette);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlaynotify-onclipchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClipChange(in RECT pSourceRect, in RECT pDestinationRect, in RGNDATA pRgnData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlaynotify-oncolorkeychange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnColorKeyChange(in COLORKEY pColorKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlaynotify-onpositionchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPositionChange(in RECT pSourceRect, in RECT pDestinationRect);
}
