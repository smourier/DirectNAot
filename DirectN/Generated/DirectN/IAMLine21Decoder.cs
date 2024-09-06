#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/il21dec/nn-il21dec-iamline21decoder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6e8d4a21-310c-11d0-b79a-00aa003767a7")]
public partial interface IAMLine21Decoder
{
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getdecoderlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderLevel(ref AM_LINE21_CCLEVEL lpLevel);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getcurrentservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentService(ref AM_LINE21_CCSERVICE lpService);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setcurrentservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentService(AM_LINE21_CCSERVICE Service);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getservicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceState(ref AM_LINE21_CCSTATE lpState);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setservicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetServiceState(AM_LINE21_CCSTATE State);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFormat(ref BITMAPINFOHEADER lpbmih);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFormat(ref BITMAPINFO lpbmi);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(ref uint pdwPhysColor);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(uint dwPhysColor);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getredrawalways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRedrawAlways(ref BOOL lpbOption);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setredrawalways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedrawAlways(BOOL bOption);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-getdrawbackgroundmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDrawBackgroundMode(ref AM_LINE21_DRAWBGMODE lpMode);
    
    // https://learn.microsoft.com/windows/win32/api/il21dec/nf-il21dec-iamline21decoder-setdrawbackgroundmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawBackgroundMode(AM_LINE21_DRAWBGMODE Mode);
}
