#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-dvd_audio_format
public enum DVD_AUDIO_FORMAT
{
    DVD_AudioFormat_AC3 = 0,
    DVD_AudioFormat_MPEG1 = 1,
    DVD_AudioFormat_MPEG1_DRC = 2,
    DVD_AudioFormat_MPEG2 = 3,
    DVD_AudioFormat_MPEG2_DRC = 4,
    DVD_AudioFormat_LPCM = 5,
    DVD_AudioFormat_DTS = 6,
    DVD_AudioFormat_SDDS = 7,
    DVD_AudioFormat_Other = 8,
}
