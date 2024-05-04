#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_trimming_granularity
public enum DWRITE_TRIMMING_GRANULARITY
{
    DWRITE_TRIMMING_GRANULARITY_NONE = 0,
    DWRITE_TRIMMING_GRANULARITY_CHARACTER = 1,
    DWRITE_TRIMMING_GRANULARITY_WORD = 2,
}
