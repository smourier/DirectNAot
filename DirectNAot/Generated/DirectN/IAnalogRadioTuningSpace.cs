namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ianalogradiotuningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2a6e293b-2595-11d3-b64c-00c04f79498e")]
public partial interface IAnalogRadioTuningSpace : ITuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-get_minfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinFrequency(out int MinFrequencyVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-put_minfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinFrequency(int NewMinFrequencyVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-get_maxfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxFrequency(out int MaxFrequencyVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-put_maxfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxFrequency(int NewMaxFrequencyVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-get_step
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Step(out int StepVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace-put_step
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Step(int NewStepVal);
}
