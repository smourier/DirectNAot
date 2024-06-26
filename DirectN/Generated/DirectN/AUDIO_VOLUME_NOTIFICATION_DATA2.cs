﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_volume_notification_data2
public partial struct AUDIO_VOLUME_NOTIFICATION_DATA2
{
    public nint notificationData;
    public float masterVolumeInDb;
    public float volumeMinInDb;
    public float volumeMaxInDb;
    public float volumeIncrementInDb;
    public uint step;
    public uint stepCount;
    public InlineArraySingle_1 channelVolumesInDb; // variable-length array placeholder
}
