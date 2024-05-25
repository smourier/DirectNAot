namespace DirectN;

[GeneratedComInterface, Guid("13e670f5-1a5a-11cf-abeb-00aa00b65ea1")]
public partial interface ITextHost2 : ITextHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxIsDoubleClickPending();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindow(out HWND phwnd);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSetForegroundWindow();

    [PreserveSig]
    HPALETTE TxGetPalette();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEastAsianFlags(out ES pFlags);

    [PreserveSig]
    HCURSOR TxSetCursor2(HCURSOR hcur, [MarshalAs(UnmanagedType.U4)] bool bText);

    [PreserveSig]
    void TxFreeTextServicesNotification();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEditStyle(TXES dwItem, out TXES pdwData);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindowStyles(out WINDOW_STYLE pdwStyle, out WINDOW_EX_STYLE pdwExStyle);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxShowDropCaret([MarshalAs(UnmanagedType.U4)] bool fShow, HDC hdc, nint prc);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDestroyCaret();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetHorzExtent(out int plHorzExtent);
}
