﻿#nullable enable
namespace DirectN;

public enum MPEG2StreamType
{
    BDA_UNITIALIZED_MPEG2STREAMTYPE = -1,
    Reserved1 = 0,
    ISO_IEC_11172_2_VIDEO = 1,
    ISO_IEC_13818_2_VIDEO = 2,
    ISO_IEC_11172_3_AUDIO = 3,
    ISO_IEC_13818_3_AUDIO = 4,
    ISO_IEC_13818_1_PRIVATE_SECTION = 5,
    ISO_IEC_13818_1_PES = 6,
    ISO_IEC_13522_MHEG = 7,
    ANNEX_A_DSM_CC = 8,
    ITU_T_REC_H_222_1 = 9,
    ISO_IEC_13818_6_TYPE_A = 10,
    ISO_IEC_13818_6_TYPE_B = 11,
    ISO_IEC_13818_6_TYPE_C = 12,
    ISO_IEC_13818_6_TYPE_D = 13,
    ISO_IEC_13818_1_AUXILIARY = 14,
    ISO_IEC_13818_7_AUDIO = 15,
    ISO_IEC_14496_2_VISUAL = 16,
    ISO_IEC_14496_3_AUDIO = 17,
    ISO_IEC_14496_1_IN_PES = 18,
    ISO_IEC_14496_1_IN_SECTION = 19,
    ISO_IEC_13818_6_DOWNLOAD = 20,
    METADATA_IN_PES = 21,
    METADATA_IN_SECTION = 22,
    METADATA_IN_DATA_CAROUSEL = 23,
    METADATA_IN_OBJECT_CAROUSEL = 24,
    METADATA_IN_DOWNLOAD_PROTOCOL = 25,
    IRPM_STREAMM = 26,
    ITU_T_H264 = 27,
    ISO_IEC_13818_1_RESERVED = 28,
    USER_PRIVATE = 16,
    HEVC_VIDEO_OR_TEMPORAL_VIDEO = 36,
    HEVC_TEMPORAL_VIDEO_SUBSET = 37,
    ISO_IEC_USER_PRIVATE = 128,
    DOLBY_AC3_AUDIO = 129,
    DOLBY_DIGITAL_PLUS_AUDIO_ATSC = 135,
}
