#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/endpointvolume/nn-endpointvolume-iaudioendpointvolumecallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("657804fa-d6ad-4496-8a60-352752af4f89")]
public partial interface IAudioEndpointVolumeCallback
{
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolumecallback-onnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNotify(ref AUDIO_VOLUME_NOTIFICATION_DATA pNotify);
}
