﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfstandardvideoformat
public enum MFStandardVideoFormat
{
    MFStdVideoFormat_reserved = 0,
    MFStdVideoFormat_NTSC = 1,
    MFStdVideoFormat_PAL = 2,
    MFStdVideoFormat_DVD_NTSC = 3,
    MFStdVideoFormat_DVD_PAL = 4,
    MFStdVideoFormat_DV_PAL = 5,
    MFStdVideoFormat_DV_NTSC = 6,
    MFStdVideoFormat_ATSC_SD480i = 7,
    MFStdVideoFormat_ATSC_HD1080i = 8,
    MFStdVideoFormat_ATSC_HD720p = 9,
}
