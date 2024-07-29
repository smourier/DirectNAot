#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudiopeakmeter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("dd79923c-0599-45e0-b8b6-c8df7db6e796")]
public partial interface IAudioPeakMeter
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiopeakmeter-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pcChannels);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiopeakmeter-getlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevel(uint nChannel, out float pfLevel);
}
