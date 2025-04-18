#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itexthost2
[GeneratedComInterface, Guid("13e670f5-1a5a-11cf-abeb-00aa00b65ea1")]
public partial interface ITextHost2 : ITextHost
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txisdoubleclickpending
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.U4)]
    bool TxIsDoubleClickPending();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindow
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindow(nint /* optional HWND* */ phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetforegroundwindow
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSetForegroundWindow();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetpalette
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    nint TxGetPalette();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteastasianflags
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEastAsianFlags(nint /* optional int* */ pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txsetcursor2
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    nint TxSetCursor2(HCURSOR hcur, BOOL bText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txfreetextservicesnotification
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    void TxFreeTextServicesNotification();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgeteditstyle
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetEditStyle(uint dwItem, nint /* optional uint* */ pdwData);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgetwindowstyles
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetWindowStyles(nint /* optional uint* */ pdwStyle, nint /* optional uint* */ pdwExStyle);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txshowdropcaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxShowDropCaret(BOOL fShow, HDC hdc, nint /* optional RECT* */ prc);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txdestroycaret
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDestroyCaret();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itexthost2-txgethorzextent
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetHorzExtent(nint /* optional int* */ plHorzExtent);
}
