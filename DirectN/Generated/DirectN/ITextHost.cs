#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itexthost
[GeneratedComInterface, Guid("c5bdd8d0-d26e-11ce-a89e-00aa006cadc5")]
public partial interface ITextHost
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetdc
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    HDC TxGetDC();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txreleasedc
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    int TxReleaseDC(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txshowscrollbar
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxShowScrollBar(int fnBar, BOOL fShow);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txenablescrollbar
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxEnableScrollBar(SCROLLBAR_CONSTANTS fuSBFlags, int fuArrowflags);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetscrollrange
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxSetScrollRange(int fnBar, int nMinPos, int nMaxPos, BOOL fRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetscrollpos
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxSetScrollPos(int fnBar, int nPos, BOOL fRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txinvalidaterect
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxInvalidateRect(nint /* optional RECT* */ prc, BOOL fMode);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txviewchange
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxViewChange(BOOL fUpdate);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txcreatecaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxCreateCaret(HBITMAP hbmp, int xWidth, int yHeight);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txshowcaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxShowCaret(BOOL fShow);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcaretpos
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxSetCaretPos(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsettimer
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxSetTimer(uint idTimer, uint uTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txkilltimer
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxKillTimer(uint idTimer);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txscrollwindowex
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxScrollWindowEx(int dx, int dy, nint /* optional RECT* */ lprcScroll, nint /* optional RECT* */ lprcClip, HRGN hrgnUpdate, nint /* optional RECT* */ lprcUpdate, SCROLL_WINDOW_FLAGS fuScroll);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcapture
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxSetCapture(BOOL fCapture);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetfocus
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxSetFocus();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txsetcursor
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxSetCursor(HCURSOR hcur, BOOL fText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txscreentoclient
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxScreenToClient(nint /* optional POINT* */ lppt);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txclienttoscreen
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    BOOL TxClientToScreen(nint /* optional POINT* */ lppt);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txactivate
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxActivate(nint /* optional int* */ plOldState);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txdeactivate
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDeactivate(int lNewState);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetclientrect
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetClientRect(nint /* optional RECT* */ prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetviewinset
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetViewInset(nint /* optional RECT* */ prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetcharformat
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetCharFormat(nint /* optional CHARFORMATW** */ ppCF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetparaformat
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetParaFormat(nint /* optional PARAFORMAT** */ ppPF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetsyscolor
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    COLORREF TxGetSysColor(SYS_COLOR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetbackstyle
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetBackStyle(nint /* optional TXTBACKSTYLE* */ pstyle);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetmaxlength
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetMaxLength(nint /* optional uint* */ plength);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetscrollbars
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetScrollBars(nint /* optional uint* */ pdwScrollBar);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetpasswordchar
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPasswordChar(out sbyte pch);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetacceleratorpos
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetAcceleratorPos(nint /* optional int* */ pcp);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetextent
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetExtent(nint /* optional SIZE* */ lpExtent);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-ontxcharformatchange
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxCharFormatChange(in CHARFORMATW pCF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-ontxparaformatchange
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxParaFormatChange(in PARAFORMAT pPF);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetpropertybits
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPropertyBits(uint dwMask, nint /* optional uint* */ pdwBits);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txnotify
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxNotify(uint iNotify, nint /* optional void* */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-tximmgetcontext
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    HIMC TxImmGetContext();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-tximmreleasecontext
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxImmReleaseContext(HIMC himc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost-txgetselectionbarwidth
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetSelectionBarWidth(nint /* optional int* */ lSelBarWidth);
}
