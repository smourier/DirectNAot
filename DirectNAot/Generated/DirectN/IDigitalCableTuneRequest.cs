namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idigitalcabletunerequest
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bad7753b-6b37-4810-ae57-3ce0c4a9e6cb")]
public partial interface IDigitalCableTuneRequest : IATSCChannelTuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletunerequest-get_majorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MajorChannel(out int pMajorChannel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletunerequest-put_majorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MajorChannel(int MajorChannel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletunerequest-get_sourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceID(out int pSourceID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idigitalcabletunerequest-put_sourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceID(int SourceID);
}
