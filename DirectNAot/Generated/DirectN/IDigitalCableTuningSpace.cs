namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idigitalcabletuningspace
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("013f9f9c-b449-4ec7-a6d2-9d4f2fc70ae5")]
public partial interface IDigitalCableTuningSpace : IATSCTuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-get_minmajorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinMajorChannel(out int MinMajorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-put_minmajorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinMajorChannel(int NewMinMajorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-get_maxmajorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxMajorChannel(out int MaxMajorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-put_maxmajorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxMajorChannel(int NewMaxMajorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-get_minsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinSourceID(out int MinSourceIDVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-put_minsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinSourceID(int NewMinSourceIDVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-get_maxsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxSourceID(out int MaxSourceIDVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletuningspace-put_maxsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxSourceID(int NewMaxSourceIDVal);
}
