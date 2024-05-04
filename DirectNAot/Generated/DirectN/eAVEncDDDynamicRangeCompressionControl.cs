#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencdddynamicrangecompressioncontrol
public enum eAVEncDDDynamicRangeCompressionControl
{
    eAVEncDDDynamicRangeCompressionControl_None = 0,
    eAVEncDDDynamicRangeCompressionControl_FilmStandard = 1,
    eAVEncDDDynamicRangeCompressionControl_FilmLight = 2,
    eAVEncDDDynamicRangeCompressionControl_MusicStandard = 3,
    eAVEncDDDynamicRangeCompressionControl_MusicLight = 4,
    eAVEncDDDynamicRangeCompressionControl_Speech = 5,
}
