#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ne-mftransform-_mft_input_stream_info_flags
public enum _MFT_INPUT_STREAM_INFO_FLAGS
{
    MFT_INPUT_STREAM_WHOLE_SAMPLES = 1,
    MFT_INPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 2,
    MFT_INPUT_STREAM_FIXED_SAMPLE_SIZE = 4,
    MFT_INPUT_STREAM_HOLDS_BUFFERS = 8,
    MFT_INPUT_STREAM_DOES_NOT_ADDREF = 256,
    MFT_INPUT_STREAM_REMOVABLE = 512,
    MFT_INPUT_STREAM_OPTIONAL = 1024,
    MFT_INPUT_STREAM_PROCESSES_IN_PLACE = 2048,
}
