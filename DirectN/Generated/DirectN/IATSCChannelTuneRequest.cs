#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iatscchanneltunerequest
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0369b4e1-45b6-11d3-b650-00c04f79498e")]
public partial interface IATSCChannelTuneRequest : IChannelTuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatscchanneltunerequest-get_minorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinorChannel(out int MinorChannel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatscchanneltunerequest-put_minorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinorChannel(int MinorChannel);
}
