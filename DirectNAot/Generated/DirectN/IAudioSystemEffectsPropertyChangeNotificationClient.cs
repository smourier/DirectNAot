#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-iaudiosystemeffectspropertychangenotificationclient
[GeneratedComInterface, Guid("20049d40-56d5-400e-a2ef-385599feed49")]
public partial interface IAudioSystemEffectsPropertyChangeNotificationClient
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iaudiosystemeffectspropertychangenotificationclient-onpropertychanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPropertyChanged(AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE type, PROPERTYKEY key);
}
