#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_endpoint_volume_apo_notification_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR
{
    public nint device;
}
