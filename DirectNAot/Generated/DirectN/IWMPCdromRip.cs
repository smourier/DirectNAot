namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcdromrip
[GeneratedComInterface, Guid("56e2294f-69ed-4629-a869-aea72c0dcc2c")]
public partial interface IWMPCdromRip
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromrip-get_ripstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ripState(ref WMPRipState pwmprs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromrip-get_ripprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ripProgress(ref int plProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromrip-startrip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startRip();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcdromrip-stoprip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stopRip();
}
