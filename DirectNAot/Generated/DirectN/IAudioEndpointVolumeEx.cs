#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/endpointvolume/nn-endpointvolume-iaudioendpointvolumeex
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("66e11784-f695-4f28-a505-a7080081a78f")]
public partial interface IAudioEndpointVolumeEx : IAudioEndpointVolume
{
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolumeex-getvolumerangechannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolumeRangeChannel(uint iChannel, out float pflVolumeMindB, out float pflVolumeMaxdB, out float pflVolumeIncrementdB);
}
