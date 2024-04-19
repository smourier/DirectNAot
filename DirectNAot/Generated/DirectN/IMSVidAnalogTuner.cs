namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidanalogtuner
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1c15d47e-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidAnalogTuner : IMSVidTuner
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-get_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Channel(out int Channel);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-put_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Channel(int Channel);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-get_videofrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoFrequency(out int lcc);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-get_audiofrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioFrequency(out int lcc);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out int lcc);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(int lcc);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-get_sap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAP(out VARIANT_BOOL pfSapOn);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-put_sap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SAP(VARIANT_BOOL fSapOn);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner-channelavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChannelAvailable(int nChannel, out int SignalStrength, out VARIANT_BOOL fSignalPresent);
}
