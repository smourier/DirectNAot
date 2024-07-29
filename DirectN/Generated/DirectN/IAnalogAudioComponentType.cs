#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ianalogaudiocomponenttype
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2cfeb2a8-1787-4a24-a941-c6eaec39c842")]
public partial interface IAnalogAudioComponentType : IComponentType
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogaudiocomponenttype-get_analogaudiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AnalogAudioMode(out TVAudioMode Mode);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogaudiocomponenttype-put_analogaudiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AnalogAudioMode(TVAudioMode Mode);
}
