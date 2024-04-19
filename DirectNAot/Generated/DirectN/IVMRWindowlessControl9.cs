namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrwindowlesscontrol9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8f537d09-f85e-4414-b23b-502e54c79927")]
public partial interface IVMRWindowlessControl9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getnativevideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getminidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinIdealVideoSize(out int lpWidth, out int lpHeight);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getmaxidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-setvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoPosition(FoundationRECT lpSRCRect, FoundationRECT lpDSTRect);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPosition(out FoundationRECT lpSRCRect, out FoundationRECT lpDSTRect);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint lpAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint AspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-setvideoclippingwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoClippingWindow(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-repaintvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RepaintVideo(HWND hwnd, HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-displaymodechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayModeChanged();
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getcurrentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentImage(out nint /* byte array */ lpDib);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(COLORREF Clr);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrwindowlesscontrol9-getbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorderColor(out COLORREF lpClr);
}
