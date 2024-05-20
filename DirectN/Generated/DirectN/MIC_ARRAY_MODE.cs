#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ne-wmcodecdsp-mic_array_mode
public enum MIC_ARRAY_MODE
{
    MICARRAY_SINGLE_CHAN = 0,
    MICARRAY_SIMPLE_SUM = 256,
    MICARRAY_SINGLE_BEAM = 512,
    MICARRAY_FIXED_BEAM = 1024,
    MICARRAY_EXTERN_BEAM = 2048,
}
