#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itexthost2
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ITextHost2 : ITextHost
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txisdoubleclickpending
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxIsDoubleClickPending();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindow
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindow(ref HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetforegroundwindow
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSetForegroundWindow();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetpalette
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    HPALETTE TxGetPalette();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteastasianflags
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEastAsianFlags(ref int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetcursor2
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    HCURSOR TxSetCursor2(HCURSOR hcur, BOOL bText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txfreetextservicesnotification
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxFreeTextServicesNotification();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteditstyle
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEditStyle(uint dwItem, ref uint pdwData);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindowstyles
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindowStyles(ref uint pdwStyle, ref uint pdwExStyle);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txshowdropcaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxShowDropCaret(BOOL fShow, HDC hdc, ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txdestroycaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDestroyCaret();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgethorzextent
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetHorzExtent(ref int plHorzExtent);
}
