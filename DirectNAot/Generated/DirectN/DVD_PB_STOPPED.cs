﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdevcod/ne-dvdevcod-dvd_pb_stopped
public enum DVD_PB_STOPPED
{
    DVD_PB_STOPPED_Other = 0,
    DVD_PB_STOPPED_NoBranch = 1,
    DVD_PB_STOPPED_NoFirstPlayDomain = 2,
    DVD_PB_STOPPED_StopCommand = 3,
    DVD_PB_STOPPED_Reset = 4,
    DVD_PB_STOPPED_DiscEjected = 5,
    DVD_PB_STOPPED_IllegalNavCommand = 6,
    DVD_PB_STOPPED_PlayPeriodAutoStop = 7,
    DVD_PB_STOPPED_PlayChapterAutoStop = 8,
    DVD_PB_STOPPED_ParentalFailure = 9,
    DVD_PB_STOPPED_RegionFailure = 10,
    DVD_PB_STOPPED_MacrovisionFailure = 11,
    DVD_PB_STOPPED_DiscReadError = 12,
    DVD_PB_STOPPED_CopyProtectFailure = 13,
    DVD_PB_STOPPED_CopyProtectOutputFailure = 14,
    DVD_PB_STOPPED_CopyProtectOutputNotSupported = 15,
}
