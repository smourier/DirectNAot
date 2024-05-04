#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-dvd_timecode_flags
public enum DVD_TIMECODE_FLAGS
{
    DVD_TC_FLAG_25fps = 1,
    DVD_TC_FLAG_30fps = 2,
    DVD_TC_FLAG_DropFrame = 4,
    DVD_TC_FLAG_Interpolated = 8,
}
