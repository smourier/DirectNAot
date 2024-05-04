#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/ne-mmdeviceapi-audio_systemeffects_propertystore_type
public enum AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE
{
    AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE_DEFAULT = 0,
    AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE_USER = 1,
    AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE_VOLATILE = 2,
    AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE_ENUM_COUNT = 3,
}
