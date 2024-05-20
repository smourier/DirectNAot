#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/ne-mmdeviceapi-endpointformfactor
public enum EndpointFormFactor
{
    RemoteNetworkDevice = 0,
    Speakers = 1,
    LineLevel = 2,
    Headphones = 3,
    Microphone = 4,
    Headset = 5,
    Handset = 6,
    UnknownDigitalPassthrough = 7,
    SPDIF = 8,
    DigitalAudioDisplayDevice = 9,
    UnknownFormFactor = 10,
    EndpointFormFactor_enum_count = 11,
}
