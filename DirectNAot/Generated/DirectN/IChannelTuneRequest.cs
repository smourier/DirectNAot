namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ichanneltunerequest
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0369b4e0-45b6-11d3-b650-00c04f79498e")]
public partial interface IChannelTuneRequest : ITuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ichanneltunerequest-get_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Channel(out int Channel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ichanneltunerequest-put_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Channel(int Channel);
}
