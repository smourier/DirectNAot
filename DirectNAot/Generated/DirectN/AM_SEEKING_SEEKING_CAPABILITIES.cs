namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-am_seeking_seeking_capabilities
public enum AM_SEEKING_SEEKING_CAPABILITIES
{
    AM_SEEKING_CanSeekAbsolute = 1,
    AM_SEEKING_CanSeekForwards = 2,
    AM_SEEKING_CanSeekBackwards = 4,
    AM_SEEKING_CanGetCurrentPos = 8,
    AM_SEEKING_CanGetStopPos = 16,
    AM_SEEKING_CanGetDuration = 32,
    AM_SEEKING_CanPlayBackwards = 64,
    AM_SEEKING_CanDoSegments = 128,
    AM_SEEKING_Source = 256,
}
