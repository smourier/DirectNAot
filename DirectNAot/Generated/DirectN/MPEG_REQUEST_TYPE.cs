#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ne-mpeg2structs-mpeg_request_type
public enum MPEG_REQUEST_TYPE
{
    MPEG_RQST_UNKNOWN = 0,
    MPEG_RQST_GET_SECTION = 1,
    MPEG_RQST_GET_SECTION_ASYNC = 2,
    MPEG_RQST_GET_TABLE = 3,
    MPEG_RQST_GET_TABLE_ASYNC = 4,
    MPEG_RQST_GET_SECTIONS_STREAM = 5,
    MPEG_RQST_GET_PES_STREAM = 6,
    MPEG_RQST_GET_TS_STREAM = 7,
    MPEG_RQST_START_MPE_STREAM = 8,
}
