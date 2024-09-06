#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/iwstdec/nn-iwstdec-iamwstdecoder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c056de21-75c2-11d3-a184-00105aef9f33")]
public partial interface IAMWstDecoder
{
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getdecoderlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderLevel(ref AM_WST_LEVEL lpLevel);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getcurrentservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentService(ref AM_WST_SERVICE lpService);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getservicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceState(ref AM_WST_STATE lpState);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setservicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetServiceState(AM_WST_STATE State);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFormat(ref BITMAPINFOHEADER lpbmih);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFormat(ref BITMAPINFO lpbmi);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(ref uint pdwPhysColor);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(uint dwPhysColor);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getredrawalways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRedrawAlways(ref BOOL lpbOption);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setredrawalways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedrawAlways(BOOL bOption);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getdrawbackgroundmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDrawBackgroundMode(ref AM_WST_DRAWBGMODE lpMode);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setdrawbackgroundmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawBackgroundMode(AM_WST_DRAWBGMODE Mode);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setanswermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAnswerMode(BOOL bAnswer);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getanswermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAnswerMode(ref BOOL pbAnswer);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setholdpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHoldPage(BOOL bHoldPage);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getholdpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHoldPage(ref BOOL pbHoldPage);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-getcurrentpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPage(ref AM_WST_PAGE pWstPage);
    
    // https://learn.microsoft.com/windows/win32/api/iwstdec/nf-iwstdec-iamwstdecoder-setcurrentpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPage(AM_WST_PAGE WstPage);
}
