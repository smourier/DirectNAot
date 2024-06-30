#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_endpoint_volume_change_notification
public partial struct AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION
{
    public nint endpoint;
    public nint volume;
}
