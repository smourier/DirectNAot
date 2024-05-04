#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_volume_notification_data2
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_VOLUME_NOTIFICATION_DATA2
{
    public nint notificationData;
    public float masterVolumeInDb;
    public float volumeMinInDb;
    public float volumeMaxInDb;
    public float volumeIncrementInDb;
    public uint step;
    public uint stepCount;
    public InlineArraySingle1 channelVolumesInDb; // variable-length array placeholder
}
