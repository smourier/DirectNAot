﻿#nullable enable
namespace DirectN;

public enum KSPROPERTY_AUDIO
{
    KSPROPERTY_AUDIO_LATENCY = 1,
    KSPROPERTY_AUDIO_COPY_PROTECTION = 2,
    KSPROPERTY_AUDIO_CHANNEL_CONFIG = 3,
    KSPROPERTY_AUDIO_VOLUMELEVEL = 4,
    KSPROPERTY_AUDIO_POSITION = 5,
    KSPROPERTY_AUDIO_DYNAMIC_RANGE = 6,
    KSPROPERTY_AUDIO_QUALITY = 7,
    KSPROPERTY_AUDIO_SAMPLING_RATE = 8,
    KSPROPERTY_AUDIO_DYNAMIC_SAMPLING_RATE = 9,
    KSPROPERTY_AUDIO_MIX_LEVEL_TABLE = 10,
    KSPROPERTY_AUDIO_MIX_LEVEL_CAPS = 11,
    KSPROPERTY_AUDIO_MUX_SOURCE = 12,
    KSPROPERTY_AUDIO_MUTE = 13,
    KSPROPERTY_AUDIO_BASS = 14,
    KSPROPERTY_AUDIO_MID = 15,
    KSPROPERTY_AUDIO_TREBLE = 16,
    KSPROPERTY_AUDIO_BASS_BOOST = 17,
    KSPROPERTY_AUDIO_EQ_LEVEL = 18,
    KSPROPERTY_AUDIO_NUM_EQ_BANDS = 19,
    KSPROPERTY_AUDIO_EQ_BANDS = 20,
    KSPROPERTY_AUDIO_AGC = 21,
    KSPROPERTY_AUDIO_DELAY = 22,
    KSPROPERTY_AUDIO_LOUDNESS = 23,
    KSPROPERTY_AUDIO_WIDE_MODE = 24,
    KSPROPERTY_AUDIO_WIDENESS = 25,
    KSPROPERTY_AUDIO_REVERB_LEVEL = 26,
    KSPROPERTY_AUDIO_CHORUS_LEVEL = 27,
    KSPROPERTY_AUDIO_DEV_SPECIFIC = 28,
    KSPROPERTY_AUDIO_DEMUX_DEST = 29,
    KSPROPERTY_AUDIO_STEREO_ENHANCE = 30,
    KSPROPERTY_AUDIO_MANUFACTURE_GUID = 31,
    KSPROPERTY_AUDIO_PRODUCT_GUID = 32,
    KSPROPERTY_AUDIO_CPU_RESOURCES = 33,
    KSPROPERTY_AUDIO_STEREO_SPEAKER_GEOMETRY = 34,
    KSPROPERTY_AUDIO_SURROUND_ENCODE = 35,
    KSPROPERTY_AUDIO_3D_INTERFACE = 36,
    KSPROPERTY_AUDIO_PEAKMETER = 37,
    KSPROPERTY_AUDIO_ALGORITHM_INSTANCE = 38,
    KSPROPERTY_AUDIO_FILTER_STATE = 39,
    KSPROPERTY_AUDIO_PREFERRED_STATUS = 40,
    KSPROPERTY_AUDIO_PEQ_MAX_BANDS = 41,
    KSPROPERTY_AUDIO_PEQ_NUM_BANDS = 42,
    KSPROPERTY_AUDIO_PEQ_BAND_CENTER_FREQ = 43,
    KSPROPERTY_AUDIO_PEQ_BAND_Q_FACTOR = 44,
    KSPROPERTY_AUDIO_PEQ_BAND_LEVEL = 45,
    KSPROPERTY_AUDIO_CHORUS_MODULATION_RATE = 46,
    KSPROPERTY_AUDIO_CHORUS_MODULATION_DEPTH = 47,
    KSPROPERTY_AUDIO_REVERB_TIME = 48,
    KSPROPERTY_AUDIO_REVERB_DELAY_FEEDBACK = 49,
    KSPROPERTY_AUDIO_POSITIONEX = 50,
    KSPROPERTY_AUDIO_MIC_ARRAY_GEOMETRY = 51,
    KSPROPERTY_AUDIO_PRESENTATION_POSITION = 52,
    KSPROPERTY_AUDIO_WAVERT_CURRENT_WRITE_POSITION = 53,
    KSPROPERTY_AUDIO_LINEAR_BUFFER_POSITION = 54,
    KSPROPERTY_AUDIO_PEAKMETER2 = 55,
    KSPROPERTY_AUDIO_WAVERT_CURRENT_WRITE_LASTBUFFER_POSITION = 56,
    KSPROPERTY_AUDIO_VOLUMELIMIT_ENGAGED = 57,
    KSPROPERTY_AUDIO_MIC_SENSITIVITY = 58,
    KSPROPERTY_AUDIO_MIC_SNR = 59,
    KSPROPERTY_AUDIO_MIC_SENSITIVITY2 = 60,
}
