#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ne-mediaobj-_dmo_output_data_buffer_flags
public enum _DMO_OUTPUT_DATA_BUFFER_FLAGS
{
    DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT = 1,
    DMO_OUTPUT_DATA_BUFFERF_TIME = 2,
    DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH = 4,
    DMO_OUTPUT_DATA_BUFFERF_DISCONTINUITY = 8,
    DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE = 16777216,
}
