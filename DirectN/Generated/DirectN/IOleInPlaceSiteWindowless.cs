#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleinplacesitewindowless
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("922eada0-3424-11cf-b670-00aa004cd6d8")]
public partial interface IOleInPlaceSiteWindowless : IOleInPlaceSiteEx
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-canwindowlessactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanWindowlessActivate();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-getcapture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapture();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-setcapture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCapture(BOOL fCapture);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-getfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocus();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-setfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocus(BOOL fFocus);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-getdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDC(in RECT pRect, uint grfFlags, out HDC phDC);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-releasedc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDC(HDC hDC);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-invalidaterect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvalidateRect(in RECT pRect, BOOL fErase);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-invalidatergn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvalidateRgn(HRGN hRGN, BOOL fErase);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-scrollrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScrollRect(int dx, int dy, in RECT pRectScroll, in RECT pRectClip);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-adjustrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdjustRect(ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesitewindowless-ondefwindowmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDefWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, out LRESULT plResult);
}
