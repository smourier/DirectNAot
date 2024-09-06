#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-imediaposition
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b2-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaPosition : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-get_duration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Duration(out double plength);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-put_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentPosition(double llTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-get_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentPosition(out double pllTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-get_stoptime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StopTime(out double pllTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-put_stoptime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StopTime(double llTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-get_prerolltime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PrerollTime(out double pllTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-put_prerolltime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PrerollTime(double llTime);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-put_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Rate(double dRate);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-get_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rate(out double pdRate);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-canseekforward
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanSeekForward(out int pCanSeekForward);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaposition-canseekbackward
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanSeekBackward(out int pCanSeekBackward);
}
