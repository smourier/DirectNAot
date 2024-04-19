namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdevcod/ne-dvdevcod-dvd_error
public enum DVD_ERROR
{
    DVD_ERROR_Unexpected = 1,
    DVD_ERROR_CopyProtectFail = 2,
    DVD_ERROR_InvalidDVD1_0Disc = 3,
    DVD_ERROR_InvalidDiscRegion = 4,
    DVD_ERROR_LowParentalLevel = 5,
    DVD_ERROR_MacrovisionFail = 6,
    DVD_ERROR_IncompatibleSystemAndDecoderRegions = 7,
    DVD_ERROR_IncompatibleDiscAndDecoderRegions = 8,
    DVD_ERROR_CopyProtectOutputFail = 9,
    DVD_ERROR_CopyProtectOutputNotSupported = 10,
}
