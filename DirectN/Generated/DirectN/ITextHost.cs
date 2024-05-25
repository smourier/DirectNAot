#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itexthost
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ITextHost
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetdc
    [PreserveSig]
    HDC TxGetDC();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txreleasedc
    [PreserveSig]
    int TxReleaseDC(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txshowscrollbar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxShowScrollBar(int fnBar, [MarshalAs(UnmanagedType.U4)] bool fShow);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txenablescrollbar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxEnableScrollBar(SCROLLBAR_CONSTANTS fuSBFlags, int fuArrowflags);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetscrollrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetScrollRange(int fnBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.U4)] bool fRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetscrollpos
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetScrollPos(int fnBar, int nPos, [MarshalAs(UnmanagedType.U4)] bool fRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txinvalidaterect
    [PreserveSig]
    void TxInvalidateRect(ref RECT prc, [MarshalAs(UnmanagedType.U4)] bool fMode);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txviewchange
    [PreserveSig]
    void TxViewChange([MarshalAs(UnmanagedType.U4)] bool fUpdate);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txcreatecaret
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxCreateCaret(HBITMAP hbmp, int xWidth, int yHeight);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txshowcaret
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxShowCaret([MarshalAs(UnmanagedType.U4)] bool fShow);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcaretpos
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetCaretPos(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsettimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetTimer(uint idTimer, uint uTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txkilltimer
    [PreserveSig]
    void TxKillTimer(uint idTimer);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txscrollwindowex
    [PreserveSig]
    void TxScrollWindowEx(int dx, int dy, ref RECT lprcScroll, ref RECT lprcClip, HRGN hrgnUpdate, ref RECT lprcUpdate, SCROLL_WINDOW_FLAGS fuScroll);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcapture
    [PreserveSig]
    void TxSetCapture([MarshalAs(UnmanagedType.U4)] bool fCapture);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetfocus
    [PreserveSig]
    void TxSetFocus();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcursor
    [PreserveSig]
    void TxSetCursor(HCURSOR hcur, [MarshalAs(UnmanagedType.U4)] bool fText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txscreentoclient
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxScreenToClient(ref POINT lppt);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txclienttoscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxClientToScreen(ref POINT lppt);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxActivate(ref int plOldState);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txdeactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDeactivate(int lNewState);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetclientrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetClientRect(ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetviewinset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetViewInset(ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetcharformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetCharFormat(in CHARFORMATW ppCF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetparaformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetParaFormat(in PARAFORMAT ppPF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetsyscolor
    [PreserveSig]
    COLORREF TxGetSysColor(SYS_COLOR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetbackstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetBackStyle(ref TXTBACKSTYLE pstyle);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetMaxLength(ref uint plength);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetscrollbars
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetScrollBars(ref uint pdwScrollBar);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetpasswordchar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPasswordChar(out sbyte pch);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetacceleratorpos
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetAcceleratorPos(ref int pcp);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetExtent(ref SIZE lpExtent);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-ontxcharformatchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxCharFormatChange(in CHARFORMATW pCF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-ontxparaformatchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxParaFormatChange(in PARAFORMAT pPF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetpropertybits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPropertyBits(uint dwMask, ref uint pdwBits);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxNotify(uint iNotify, nint pv);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-tximmgetcontext
    [PreserveSig]
    HIMC TxImmGetContext();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-tximmreleasecontext
    [PreserveSig]
    void TxImmReleaseContext(HIMC himc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetselectionbarwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetSelectionBarWidth(ref int lSelBarWidth);
}
