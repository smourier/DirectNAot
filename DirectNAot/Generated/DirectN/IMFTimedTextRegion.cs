namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextregion
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("c8d22afc-bc47-4bdf-9b04-787e49ce3f58")]
public partial interface IMFTimedTextRegion
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out double pX, out double pY, out MF_TIMED_TEXT_UNIT_TYPE unitType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtent(out double pWidth, out double pHeight, out MF_TIMED_TEXT_UNIT_TYPE unitType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(out MFARGB bgColor);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getwritingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWritingMode(out MF_TIMED_TEXT_WRITING_MODE writingMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getdisplayalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayAlignment(out MF_TIMED_TEXT_DISPLAY_ALIGNMENT displayAlign);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getlineheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineHeight(out double pLineHeight, out MF_TIMED_TEXT_UNIT_TYPE unitType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getclipoverflow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipOverflow([MarshalAs(UnmanagedType.U4)] out bool clipOverflow);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getpadding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPadding(out double before, out double start, out double after, out double end, out MF_TIMED_TEXT_UNIT_TYPE unitType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getwrap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWrap([MarshalAs(UnmanagedType.U4)] out bool wrap);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getzindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZIndex(out int zIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextregion-getscrollmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScrollMode(out MF_TIMED_TEXT_SCROLL_MODE scrollMode);
}
