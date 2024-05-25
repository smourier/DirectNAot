#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itextservices
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface ITextServices
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txsendmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSendMessage(uint msg, WPARAM wparam, LPARAM lparam, ref LRESULT plresult);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDraw(DVASPECT dwDrawAspect, int lindex, nint pvAspect, ref DVTARGETDEVICE ptd, HDC hdcDraw, HDC hicTargetDev, ref RECTL lprcBounds, ref RECTL lprcWBounds, ref RECT lprcUpdate, nint pfnContinue, uint dwContinue, int lViewId);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgethscroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetHScroll(ref int plMin, ref int plMax, ref int plPos, ref int plPage, [MarshalAs(UnmanagedType.U4)] ref bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetvscroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetVScroll(ref int plMin, ref int plMax, ref int plPos, ref int plPage, [MarshalAs(UnmanagedType.U4)] ref bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxsetcursor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxSetCursor(DVASPECT dwDrawAspect, int lindex, nint pvAspect, ref DVTARGETDEVICE ptd, HDC hdcDraw, HDC hicTargetDev, ref RECT lprcClient, int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txqueryhitpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxQueryHitPoint(DVASPECT dwDrawAspect, int lindex, nint pvAspect, ref DVTARGETDEVICE ptd, HDC hdcDraw, HDC hicTargetDev, ref RECT lprcClient, int x, int y, ref uint pHitResult);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxinplaceactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxInPlaceActivate(ref RECT prcClient);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxinplacedeactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxInPlaceDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxuiactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxUIActivate();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxuideactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxUIDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetText(ref BSTR pbstrText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txsettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxSetText(PWSTR pszText);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetcurtargetx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetCurTargetX(ref int param0);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetbaselinepos
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetBaseLinePos(ref int param0);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetnaturalsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetNaturalSize(uint dwAspect, HDC hdcDraw, HDC hicTargetDev, ref DVTARGETDEVICE ptd, uint dwMode, in SIZE psizelExtent, ref int pwidth, ref int pheight);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetdroptarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetDropTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropTarget>))] out IDropTarget ppDropTarget);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-ontxpropertybitschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTxPropertyBitsChange(uint dwMask, uint dwBits);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices-txgetcachedsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetCachedSize(ref uint pdwWidth, ref uint pdwHeight);
}
