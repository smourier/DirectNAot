#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclientduckingcontrol
[GeneratedComInterface, Guid("c789d381-a28c-4168-b28f-d3a837924dc3")]
public partial interface IAudioClientDuckingControl
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclientduckingcontrol-setduckingoptionsforcurrentstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuckingOptionsForCurrentStream(AUDIO_DUCKING_OPTIONS options);
}
