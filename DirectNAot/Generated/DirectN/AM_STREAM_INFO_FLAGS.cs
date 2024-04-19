namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-am_stream_info_flags
public enum AM_STREAM_INFO_FLAGS
{
    AM_STREAM_INFO_START_DEFINED = 1,
    AM_STREAM_INFO_STOP_DEFINED = 2,
    AM_STREAM_INFO_DISCARDING = 4,
    AM_STREAM_INFO_STOP_SEND_EXTRA = 16,
}
