namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsettings
[GeneratedComInterface, Guid("9104d1ab-80c9-4fed-abf0-2e6417a6df14")]
public partial interface IWMPSettings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isAvailable(BSTR bstrItem, ref VARIANT_BOOL pIsAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_autostart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_autoStart(ref VARIANT_BOOL pfAutoStart);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_autostart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_autoStart(VARIANT_BOOL fAutoStart);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_baseurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_baseURL(ref BSTR pbstrBaseURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_baseurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_baseURL(BSTR bstrBaseURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_defaultframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_defaultFrame(ref BSTR pbstrDefaultFrame);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_defaultframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_defaultFrame(BSTR bstrDefaultFrame);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_invokeurls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_invokeURLs(ref VARIANT_BOOL pfInvokeURLs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_invokeurls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_invokeURLs(VARIANT_BOOL fInvokeURLs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_mute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_mute(ref VARIANT_BOOL pfMute);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_mute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_mute(VARIANT_BOOL fMute);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_playcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_playcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_playCount(int lCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_rate(ref double pdRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_rate(double dRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_balance(ref int plBalance);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_balance(int lBalance);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_volume(ref int plVolume);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_volume(int lVolume);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-getmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getMode(BSTR bstrMode, ref VARIANT_BOOL pvarfMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setMode(BSTR bstrMode, VARIANT_BOOL varfMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-get_enableerrordialogs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_enableErrorDialogs(ref VARIANT_BOOL pfEnableErrorDialogs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsettings-put_enableerrordialogs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_enableErrorDialogs(VARIANT_BOOL fEnableErrorDialogs);
}
