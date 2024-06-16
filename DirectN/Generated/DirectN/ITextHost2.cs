#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itexthost2
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ITextHost2 : ITextHost
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txisdoubleclickpending
    [PreserveSig]
    BOOL TxIsDoubleClickPending();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindow(ref HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetforegroundwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSetForegroundWindow();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetpalette
    [PreserveSig]
    HPALETTE TxGetPalette();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteastasianflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEastAsianFlags(ref int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetcursor2
    [PreserveSig]
    HCURSOR TxSetCursor2(HCURSOR hcur, BOOL bText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txfreetextservicesnotification
    [PreserveSig]
    void TxFreeTextServicesNotification();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteditstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEditStyle(uint dwItem, ref uint pdwData);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindowstyles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindowStyles(ref uint pdwStyle, ref uint pdwExStyle);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txshowdropcaret
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxShowDropCaret(BOOL fShow, HDC hdc, ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txdestroycaret
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDestroyCaret();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgethorzextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetHorzExtent(ref int plHorzExtent);
}
