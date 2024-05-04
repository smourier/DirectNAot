#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-videoencoder_bitrate_mode
public enum VIDEOENCODER_BITRATE_MODE
{
    ConstantBitRate = 0,
    VariableBitRateAverage = 1,
    VariableBitRatePeak = 2,
}
