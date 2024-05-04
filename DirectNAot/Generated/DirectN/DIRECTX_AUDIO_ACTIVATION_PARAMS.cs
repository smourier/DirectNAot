#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/ns-mmdeviceapi-directx_audio_activation_params
[StructLayout(LayoutKind.Sequential)]
public partial struct DIRECTX_AUDIO_ACTIVATION_PARAMS
{
    public uint cbDirectXAudioActivationParams;
    public Guid guidAudioSession;
    public uint dwAudioStreamFlags;
}
