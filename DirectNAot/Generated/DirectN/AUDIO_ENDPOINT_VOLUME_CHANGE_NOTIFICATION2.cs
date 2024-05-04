#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_endpoint_volume_change_notification2
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION2
{
    public nint endpoint;
    public nint volume;
}
