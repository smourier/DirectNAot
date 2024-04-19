namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mftransform/ne-mftransform-_mft_process_output_flags
public enum _MFT_PROCESS_OUTPUT_FLAGS
{
    MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER = 1,
    MFT_PROCESS_OUTPUT_REGENERATE_LAST_OUTPUT = 2,
}
