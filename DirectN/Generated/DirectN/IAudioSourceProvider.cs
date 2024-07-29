#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ebbaf249-afc2-4582-91c6-b60df2e84954")]
public partial interface IAudioSourceProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProvideInput(uint dwSampleCount, ref uint pdwChannelCount, nint /* optional float* */ pInterleavedAudioData);
}
