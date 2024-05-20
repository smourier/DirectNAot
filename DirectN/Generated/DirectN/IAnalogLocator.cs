#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ianaloglocator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("34d1f26b-e339-430d-abce-738cb48984dc")]
public partial interface IAnalogLocator : ILocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianaloglocator-get_videostandard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoStandard(out AnalogVideoStandard AVS);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianaloglocator-put_videostandard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VideoStandard(AnalogVideoStandard AVS);
}
