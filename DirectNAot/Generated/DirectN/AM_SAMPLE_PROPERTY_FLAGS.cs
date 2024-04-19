﻿namespace DirectN;

public enum AM_SAMPLE_PROPERTY_FLAGS
{
    AM_SAMPLE_SPLICEPOINT = 1,
    AM_SAMPLE_PREROLL = 2,
    AM_SAMPLE_DATADISCONTINUITY = 4,
    AM_SAMPLE_TYPECHANGED = 8,
    AM_SAMPLE_TIMEVALID = 16,
    AM_SAMPLE_TIMEDISCONTINUITY = 64,
    AM_SAMPLE_FLUSH_ON_PAUSE = 128,
    AM_SAMPLE_STOPVALID = 256,
    AM_SAMPLE_ENDOFSTREAM = 512,
    AM_STREAM_MEDIA = 0,
    AM_STREAM_CONTROL = 1,
}
