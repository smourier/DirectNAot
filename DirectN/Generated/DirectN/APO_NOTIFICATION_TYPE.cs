﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ne-audioengineextensionapo-apo_notification_type
public enum APO_NOTIFICATION_TYPE
{
    APO_NOTIFICATION_TYPE_NONE = 0,
    APO_NOTIFICATION_TYPE_ENDPOINT_VOLUME = 1,
    APO_NOTIFICATION_TYPE_ENDPOINT_PROPERTY_CHANGE = 2,
    APO_NOTIFICATION_TYPE_SYSTEM_EFFECTS_PROPERTY_CHANGE = 3,
    APO_NOTIFICATION_TYPE_ENDPOINT_VOLUME2 = 4,
    APO_NOTIFICATION_TYPE_DEVICE_ORIENTATION = 5,
    APO_NOTIFICATION_TYPE_MICROPHONE_BOOST = 6,
}
