#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideodisplaycontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a490b1e4-ab84-4d31-a1b2-181e03b1077a")]
public partial interface IMFVideoDisplayControl
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getnativevideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoSize(ref SIZE pszVideo, ref SIZE pszARVideo);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdealVideoSize(ref SIZE pszMin, ref SIZE pszMax);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoPosition(in MFVideoNormalizedRect pnrcSource, in RECT prcDest);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getvideoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPosition(out MFVideoNormalizedRect pnrcSource, out RECT prcDest);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint dwAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint pdwAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setvideowindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoWindow(HWND hwndVideo);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getvideowindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoWindow(out HWND phwndVideo);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-repaintvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RepaintVideo();
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getcurrentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentImage(ref BITMAPINFOHEADER pBih, out nint /* byte array */ pDib, out uint pcbDib, ref long pTimeStamp);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(COLORREF Clr);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorderColor(out COLORREF pClr);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingPrefs(uint dwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingPrefs(out uint pdwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-setfullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullscreen(BOOL fFullscreen);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodisplaycontrol-getfullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullscreen(out BOOL pfFullscreen);
}
