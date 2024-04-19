namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavaudiochannelconfig
public enum eAVAudioChannelConfig
{
    eAVAudioChannelConfig_FRONT_LEFT = 1,
    eAVAudioChannelConfig_FRONT_RIGHT = 2,
    eAVAudioChannelConfig_FRONT_CENTER = 4,
    eAVAudioChannelConfig_LOW_FREQUENCY = 8,
    eAVAudioChannelConfig_BACK_LEFT = 16,
    eAVAudioChannelConfig_BACK_RIGHT = 32,
    eAVAudioChannelConfig_FRONT_LEFT_OF_CENTER = 64,
    eAVAudioChannelConfig_FRONT_RIGHT_OF_CENTER = 128,
    eAVAudioChannelConfig_BACK_CENTER = 256,
    eAVAudioChannelConfig_SIDE_LEFT = 512,
    eAVAudioChannelConfig_SIDE_RIGHT = 1024,
    eAVAudioChannelConfig_TOP_CENTER = 2048,
    eAVAudioChannelConfig_TOP_FRONT_LEFT = 4096,
    eAVAudioChannelConfig_TOP_FRONT_CENTER = 8192,
    eAVAudioChannelConfig_TOP_FRONT_RIGHT = 16384,
    eAVAudioChannelConfig_TOP_BACK_LEFT = 32768,
    eAVAudioChannelConfig_TOP_BACK_CENTER = 65536,
    eAVAudioChannelConfig_TOP_BACK_RIGHT = 131072,
}
