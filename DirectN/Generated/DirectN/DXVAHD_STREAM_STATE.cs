﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_stream_state
public enum DXVAHD_STREAM_STATE
{
    DXVAHD_STREAM_STATE_D3DFORMAT = 0,
    DXVAHD_STREAM_STATE_FRAME_FORMAT = 1,
    DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE = 2,
    DXVAHD_STREAM_STATE_OUTPUT_RATE = 3,
    DXVAHD_STREAM_STATE_SOURCE_RECT = 4,
    DXVAHD_STREAM_STATE_DESTINATION_RECT = 5,
    DXVAHD_STREAM_STATE_ALPHA = 6,
    DXVAHD_STREAM_STATE_PALETTE = 7,
    DXVAHD_STREAM_STATE_LUMA_KEY = 8,
    DXVAHD_STREAM_STATE_ASPECT_RATIO = 9,
    DXVAHD_STREAM_STATE_FILTER_BRIGHTNESS = 100,
    DXVAHD_STREAM_STATE_FILTER_CONTRAST = 101,
    DXVAHD_STREAM_STATE_FILTER_HUE = 102,
    DXVAHD_STREAM_STATE_FILTER_SATURATION = 103,
    DXVAHD_STREAM_STATE_FILTER_NOISE_REDUCTION = 104,
    DXVAHD_STREAM_STATE_FILTER_EDGE_ENHANCEMENT = 105,
    DXVAHD_STREAM_STATE_FILTER_ANAMORPHIC_SCALING = 106,
    DXVAHD_STREAM_STATE_PRIVATE = 1000,
}
