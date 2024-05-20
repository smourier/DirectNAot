#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/ne-mfreadwrite-mf_source_reader_flag
[Flags]
public enum MF_SOURCE_READER_FLAG
{
    MF_SOURCE_READERF_ERROR = 1,
    MF_SOURCE_READERF_ENDOFSTREAM = 2,
    MF_SOURCE_READERF_NEWSTREAM = 4,
    MF_SOURCE_READERF_NATIVEMEDIATYPECHANGED = 16,
    MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED = 32,
    MF_SOURCE_READERF_STREAMTICK = 256,
    MF_SOURCE_READERF_ALLEFFECTSREMOVED = 512,
}
