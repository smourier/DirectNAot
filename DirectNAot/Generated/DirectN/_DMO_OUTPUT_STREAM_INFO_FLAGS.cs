namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ne-mediaobj-_dmo_output_stream_info_flags
public enum _DMO_OUTPUT_STREAM_INFO_FLAGS
{
    DMO_OUTPUT_STREAMF_WHOLE_SAMPLES = 1,
    DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 2,
    DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE = 4,
    DMO_OUTPUT_STREAMF_DISCARDABLE = 8,
    DMO_OUTPUT_STREAMF_OPTIONAL = 16,
}
