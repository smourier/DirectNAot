#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ne-mediaobj-_dmo_input_stream_info_flags
public enum _DMO_INPUT_STREAM_INFO_FLAGS
{
    DMO_INPUT_STREAMF_WHOLE_SAMPLES = 1,
    DMO_INPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 2,
    DMO_INPUT_STREAMF_FIXED_SAMPLE_SIZE = 4,
    DMO_INPUT_STREAMF_HOLDS_BUFFERS = 8,
}
