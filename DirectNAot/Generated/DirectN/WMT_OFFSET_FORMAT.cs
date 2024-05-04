#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_offset_format
public enum WMT_OFFSET_FORMAT
{
    WMT_OFFSET_FORMAT_100NS = 0,
    WMT_OFFSET_FORMAT_FRAME_NUMBERS = 1,
    WMT_OFFSET_FORMAT_PLAYLIST_OFFSET = 2,
    WMT_OFFSET_FORMAT_TIMECODE = 3,
    WMT_OFFSET_FORMAT_100NS_APPROXIMATE = 4,
}
