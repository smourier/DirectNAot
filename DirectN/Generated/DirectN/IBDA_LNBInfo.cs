#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_lnbinfo
[GeneratedComInterface, Guid("992cf102-49f9-4719-a664-c4f23e2408f4")]
public partial interface IBDA_LNBInfo
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-put_localoscilatorfrequencylowband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalOscilatorFrequencyLowBand(uint ulLOFLow);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-get_localoscilatorfrequencylowband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalOscilatorFrequencyLowBand(ref uint pulLOFLow);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-put_localoscilatorfrequencyhighband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalOscilatorFrequencyHighBand(uint ulLOFHigh);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-get_localoscilatorfrequencyhighband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalOscilatorFrequencyHighBand(ref uint pulLOFHigh);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-put_highlowswitchfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HighLowSwitchFrequency(uint ulSwitchFrequency);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_lnbinfo-get_highlowswitchfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HighLowSwitchFrequency(ref uint pulSwitchFrequency);
}
