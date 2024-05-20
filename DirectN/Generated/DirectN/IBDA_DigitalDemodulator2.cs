#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_digitaldemodulator2
[GeneratedComInterface, Guid("525ed3ee-5cf3-4e1e-9a06-5368a84f9a6e")]
public partial interface IBDA_DigitalDemodulator2 : IBDA_DigitalDemodulator
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-put_guardinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_GuardInterval(in GuardInterval pGuardInterval);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-get_guardinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GuardInterval(ref GuardInterval pGuardInterval);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-put_transmissionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TransmissionMode(in TransmissionMode pTransmissionMode);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-get_transmissionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TransmissionMode(ref TransmissionMode pTransmissionMode);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-put_rolloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RollOff(in RollOff pRollOff);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-get_rolloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RollOff(ref RollOff pRollOff);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-put_pilot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Pilot(in Pilot pPilot);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator2-get_pilot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Pilot(ref Pilot pPilot);
}
