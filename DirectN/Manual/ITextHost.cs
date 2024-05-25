namespace DirectN;

[GeneratedComInterface, Guid("c5bdd8d0-d26e-11ce-a89e-00aa006cadc5")]
public partial interface ITextHost
{
    [PreserveSig]
    HDC TxGetDC();

    [PreserveSig]
    int TxReleaseDC(HDC hdc);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxShowScrollBar(SB fnBar, [MarshalAs(UnmanagedType.U4)] bool fShow);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxEnableScrollBar(SB fuSBFlags, ESB fuArrowflags);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetScrollRange(SB fnBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.U4)] bool fRedraw);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetScrollPos(int fnBar, int nPos, [MarshalAs(UnmanagedType.U4)] bool fRedraw);

    [PreserveSig]
    void TxInvalidateRect(nint prc, [MarshalAs(UnmanagedType.U4)] bool fMode);

    [PreserveSig]
    void TxViewChange([MarshalAs(UnmanagedType.U4)] bool fUpdate);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxCreateCaret(HBITMAP hbmp, int xWidth, int yHeight);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxShowCaret([MarshalAs(UnmanagedType.U4)] bool fShow);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetCaretPos(int x, int y);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxSetTimer(int idTimer, int uTimeout);

    [PreserveSig]
    void TxKillTimer(int idTimer);

    [PreserveSig]
    void TxScrollWindowEx(int dx, int dy, nint lprcScroll, nint lprcClip, nint hrgnUpdate, nint lprcUpdate, TSW fuScroll);

    [PreserveSig]
    void TxSetCapture([MarshalAs(UnmanagedType.U4)] bool fCapture);

    [PreserveSig]
    void TxSetFocus();

    [PreserveSig]
    void TxSetCursor(HCURSOR hcur, [MarshalAs(UnmanagedType.U4)] bool fText);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxScreenToClient(ref POINT lppt);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxClientToScreen(ref POINT lppt);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxActivate(nint plOldState);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDeactivate(int lNewState);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetClientRect(ref RECT prc);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetViewInset(ref RECT prc);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetCharFormat(out nint ppCF);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetParaFormat(out nint ppPF);

    [PreserveSig]
    COLORREF TxGetSysColor(SYS_COLOR_INDEX nIndex);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetBackStyle(out TXTBACKSTYLE pstyle);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetMaxLength(ref int plength);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetScrollBars(out SBOUT pdwScrollBar);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPasswordChar(ref char pch);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetAcceleratorPos(out int pcp);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetExtent(out SIZE lpExtent);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxCharFormatChange(ref CHARFORMAT2W pCF);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxParaFormatChange(ref PARAFORMAT2 pPF);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetPropertyBits(TXTBIT dwMask, ref TXTBIT pdwBits);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxNotify(int iNotify, nint pv);

    [PreserveSig]
    int TxImmGetContext();

    [PreserveSig]
    void TxImmReleaseContext(int himc);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetSelectionBarWidth(ref int lSelBarWidth);
}
