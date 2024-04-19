namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-_am_pushsource_flags
public enum _AM_PUSHSOURCE_FLAGS
{
    AM_PUSHSOURCECAPS_INTERNAL_RM = 1,
    AM_PUSHSOURCECAPS_NOT_LIVE = 2,
    AM_PUSHSOURCECAPS_PRIVATE_CLOCK = 4,
    AM_PUSHSOURCEREQS_USE_STREAM_CLOCK = 65536,
    AM_PUSHSOURCEREQS_USE_CLOCK_CHAIN = 131072,
}
