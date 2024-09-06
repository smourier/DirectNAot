#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclient2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("726778cd-f60a-4eda-82de-e47610cd78aa")]
public partial interface IAudioClient2 : IAudioClient
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient2-isoffloadcapable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, out BOOL pbOffloadCapable);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient2-setclientproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientProperties(in AudioClientProperties pProperties);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient2-getbuffersizelimits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferSizeLimits(in WAVEFORMATEX pFormat, BOOL bEventDriven, out long phnsMinBufferDuration, out long phnsMaxBufferDuration);
}
