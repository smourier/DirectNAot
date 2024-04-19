namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ichannelidtunerequest
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("156eff60-86f4-4e28-89fc-109799fd57ee")]
public partial interface IChannelIDTuneRequest : ITuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ichannelidtunerequest-get_channelid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelID(out BSTR ChannelID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ichannelidtunerequest-put_channelid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ChannelID(BSTR ChannelID);
}
