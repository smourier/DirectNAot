namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrwindowlesscontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7")]
public partial interface IVMRWindowlessControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getnativevideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getminidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinIdealVideoSize(out int lpWidth, out int lpHeight);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getmaxidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-setvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoPosition(FoundationRECT lpSRCRect, FoundationRECT lpDSTRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPosition(out FoundationRECT lpSRCRect, out FoundationRECT lpDSTRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint lpAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint AspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-setvideoclippingwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoClippingWindow(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-repaintvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RepaintVideo(HWND hwnd, HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-displaymodechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayModeChanged();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getcurrentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentImage(out nint /* byte array */ lpDib);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(COLORREF Clr);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorderColor(out COLORREF lpClr);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-setcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorKey(COLORREF Clr);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrwindowlesscontrol-getcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorKey(out COLORREF lpClr);
}
