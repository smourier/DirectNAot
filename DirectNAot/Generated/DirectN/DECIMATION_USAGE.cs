namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-decimation_usage
public enum DECIMATION_USAGE
{
    DECIMATION_LEGACY = 0,
    DECIMATION_USE_DECODER_ONLY = 1,
    DECIMATION_USE_VIDEOPORT_ONLY = 2,
    DECIMATION_USE_OVERLAY_ONLY = 3,
    DECIMATION_DEFAULT = 4,
}
