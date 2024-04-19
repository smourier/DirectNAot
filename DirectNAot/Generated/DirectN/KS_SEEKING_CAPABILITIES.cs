namespace DirectN;

public enum KS_SEEKING_CAPABILITIES
{
    KS_SEEKING_CanSeekAbsolute = 1,
    KS_SEEKING_CanSeekForwards = 2,
    KS_SEEKING_CanSeekBackwards = 4,
    KS_SEEKING_CanGetCurrentPos = 8,
    KS_SEEKING_CanGetStopPos = 16,
    KS_SEEKING_CanGetDuration = 32,
    KS_SEEKING_CanPlayBackwards = 64,
}
