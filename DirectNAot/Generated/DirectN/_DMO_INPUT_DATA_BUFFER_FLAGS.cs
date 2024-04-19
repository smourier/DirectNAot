namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ne-mediaobj-_dmo_input_data_buffer_flags
public enum _DMO_INPUT_DATA_BUFFER_FLAGS
{
    DMO_INPUT_DATA_BUFFERF_SYNCPOINT = 1,
    DMO_INPUT_DATA_BUFFERF_TIME = 2,
    DMO_INPUT_DATA_BUFFERF_TIMELENGTH = 4,
    DMO_INPUT_DATA_BUFFERF_DISCONTINUITY = 8,
}
