namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ianalogtvtuningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2a6e293c-2595-11d3-b64c-00c04f79498e")]
public partial interface IAnalogTVTuningSpace : ITuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-get_minchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinChannel(out int MinChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-put_minchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinChannel(int NewMinChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-get_maxchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxChannel(out int MaxChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-put_maxchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxChannel(int NewMaxChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-get_inputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputType(out TunerInputType InputTypeVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-put_inputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InputType(TunerInputType NewInputTypeVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out int CountryCodeVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogtvtuningspace-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(int NewCountryCodeVal);
}
