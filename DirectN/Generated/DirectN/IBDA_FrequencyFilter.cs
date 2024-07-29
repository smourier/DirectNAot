#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_frequencyfilter
[GeneratedComInterface, Guid("71985f47-1ca1-11d3-9cc8-00c04f7971e0")]
public partial interface IBDA_FrequencyFilter
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_autotune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Autotune(uint ulTransponder);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_autotune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Autotune(ref uint pulTransponder);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_frequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Frequency(uint ulFrequency);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_frequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Frequency(ref uint pulFrequency);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_polarity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Polarity(Polarisation Polarity);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_polarity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Polarity(ref Polarisation pPolarity);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_range
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Range(uint ulRange);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_range
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Range(ref uint pulRange);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bandwidth(uint ulBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bandwidth(ref uint pulBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-put_frequencymultiplier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FrequencyMultiplier(uint ulMultiplier);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_frequencyfilter-get_frequencymultiplier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrequencyMultiplier(ref uint pulMultiplier);
}
