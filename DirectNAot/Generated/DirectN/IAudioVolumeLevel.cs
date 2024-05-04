#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudiovolumelevel
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7fb7b48f-531d-44a2-bcb3-5ad5a134b3dc")]
public partial interface IAudioVolumeLevel : IPerChannelDbLevel
{
}
