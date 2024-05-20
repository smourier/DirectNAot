#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ne-xaudio2-xaudio2_filter_type
public enum XAUDIO2_FILTER_TYPE
{
    LowPassFilter = 0,
    BandPassFilter = 1,
    HighPassFilter = 2,
    NotchFilter = 3,
    LowPassOnePoleFilter = 4,
    HighPassOnePoleFilter = 5,
}
