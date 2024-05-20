#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_timed_text_track_kind
public enum MF_TIMED_TEXT_TRACK_KIND
{
    MF_TIMED_TEXT_TRACK_KIND_UNKNOWN = 0,
    MF_TIMED_TEXT_TRACK_KIND_SUBTITLES = 1,
    MF_TIMED_TEXT_TRACK_KIND_CAPTIONS = 2,
    MF_TIMED_TEXT_TRACK_KIND_METADATA = 3,
}
