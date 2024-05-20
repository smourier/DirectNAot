#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("13f19604-7d32-4359-93a2-a05205d90ac9")]
public partial interface IBDA_DigitalDemodulator3 : IBDA_DigitalDemodulator2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalTimeouts(in BDA_SIGNAL_TIMEOUTS pSignalTimeouts);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalTimeouts(ref BDA_SIGNAL_TIMEOUTS pSignalTimeouts);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PLPNumber(in uint pPLPNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PLPNumber(ref uint pPLPNumber);
}
