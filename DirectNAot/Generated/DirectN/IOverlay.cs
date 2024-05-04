namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ioverlay
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a1-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IOverlay
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPalette(ref uint pdwColors, out nint ppPalette);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-setpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPalette(uint dwColors, [MarshalUsing(CountElementName = nameof(dwColors))] in PALETTEENTRY[] pPalette);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getdefaultcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultColorKey(out COLORKEY pColorKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorKey(out COLORKEY pColorKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-setcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorKey(ref COLORKEY pColorKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getwindowhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowHandle(out HWND pHwnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getcliplist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipList(out RECT pSourceRect, out RECT pDestinationRect, out nint ppRgnData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-getvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPosition(out RECT pSourceRect, out RECT pDestinationRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(IOverlayNotify pOverlayNotify, uint dwInterests);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlay-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise();
}
