#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ne-mftransform-_mft_output_data_buffer_flags
public enum _MFT_OUTPUT_DATA_BUFFER_FLAGS
{
    MFT_OUTPUT_DATA_BUFFER_INCOMPLETE = 16777216,
    MFT_OUTPUT_DATA_BUFFER_FORMAT_CHANGE = 256,
    MFT_OUTPUT_DATA_BUFFER_STREAM_END = 512,
    MFT_OUTPUT_DATA_BUFFER_NO_SAMPLE = 768,
}
